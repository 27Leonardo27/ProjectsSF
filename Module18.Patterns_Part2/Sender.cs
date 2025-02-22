using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Patterns_Part2
{
    class Sender
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Run(); 
        }
    }
}
