namespace Module7.OOP.Homework;

public class Review
{
    public string Text { get; }
    public int Rating { get; }
    public User User { get; }

    public Review(User user, string text, int rating)
    {
        User = user;
        Text = text;
        Rating = rating;
    }
}