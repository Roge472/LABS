namespace DraftLab.NewFeature
{
    /// <summary>
    /// Beginning with C# 8.0, an interface may define a default implementation for members, including properties.
    /// Defining a default implementation for a property in an interface is rare
    /// because interfaces may not define instance data fields.
    /// </summary>
    /// Questions:
    ///   Is it possible to access formatting from SMSChannelMessage or on it?
    ///   Is it possible to access IsUnicode from <see cref="SMSChannelMessage"/> or on it?
    ///   Is it possible to override IsUnicode from <see cref="SMSChannelMessage"/>?
    public interface IHasCharacterSet
    {
        string CharacterSet { get; }
        string Formatting => "L";

        bool IsUnicode()
        {
            return CharacterSet.ToLower().Equals("unicode");
        }
    }

    public class SMSChannelMessage : IHasCharacterSet
    {
        public string CharacterSet => "SMS";
    }
}
