using Module11.VoiceTexterBot.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vosk;
using Newtonsoft.Json.Linq;

namespace Module11.VoiceTexterBot.Utilities
{
    internal class SpeechDetector
    {
        public static string DetectSpeech(string audioPath, float inputBitrate, string languageCode)
        {
            Vosk.Vosk.SetLogLevel(-1);
            var modelPath = Path.Combine(DirectoryExtension.GetSolutionRoot(), "Speech-models", $"vosk-model-small-{languageCode.ToLower()}");
            Model model = new(modelPath);
            return GetWords(model, audioPath, inputBitrate);
        }
   
        private static string GetWords(Model model, string audioPath, float inputBitrate)  // Основной метод для распознавания слов
        {
            
            VoskRecognizer rec = new(model, inputBitrate);  // В конструктор для распознавания передаем битрейт, а также используемую языковую модель
            rec.SetMaxAlternatives(0);
            rec.SetWords(true);

            StringBuilder textBuffer = new();

            using (Stream source = File.OpenRead(audioPath))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {                 
                    if (rec.AcceptWaveform(buffer, bytesRead))  // Распознавание отдельных слов
                    {
                        var sentenceJson = rec.Result();
                        
                        JObject sentenceObj = JObject.Parse(sentenceJson);  // Сохраняем текстовый вывод в JSON-объект и извлекаем данные
                        string sentence = (string)sentenceObj["text"];
                        textBuffer.Append(StringExtension.UppercaseFirst(sentence) + ". ");
                    }
                }
            }
           
            var finalSentence = rec.FinalResult();  // Распознавание предложений
            
            JObject finalSentenceObj = JObject.Parse(finalSentence);  // Сохраняем текстовый вывод в JSON-объект и извлекаем данные
            
            textBuffer.Append((string)finalSentenceObj["text"]);  // Собираем итоговый текст
            
            return textBuffer.ToString();  // Возвращаем в виде строки
        }
    }
}
