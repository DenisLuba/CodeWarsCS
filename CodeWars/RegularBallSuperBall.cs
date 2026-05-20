namespace CodeWars;

public class Ball(string _ballType)
{
    public string ballType { get; set; } = _ballType;

    public Ball() : this("regular") { }
}