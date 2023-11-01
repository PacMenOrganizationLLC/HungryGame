namespace HungryGame;

public class GameConfigTemplate
{
    public string Key { get; set; }
    public string Value { get; set; }
    public GameConfigTemplate(string key, string value)
    {
        Key = key;
        Value = value;
    }
}
