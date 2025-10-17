using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Exercism_Exercises.Exercises.AuthenticationSystem;

public class Authenticator
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin) => this.admin = admin;

    private readonly Identity admin;

    private readonly IDictionary<string, Identity> developers = new Dictionary<string, Identity>
    {
        ["Bertrand"] = new Identity { Email = "bert@ex.ism", EyeColor = EyeColor.Blue, },

        ["Anders"] = new Identity { Email = "anders@ex.ism", EyeColor = EyeColor.Brown, }
    };

    public Identity Admin => admin;

    public IDictionary<string, Identity> GetDevelopers() => new ReadOnlyDictionary<string, Identity>(developers);
}

public struct Identity(string email, string eyeColor)
{
    public string Email { get; set; } = email;

    public string EyeColor { get; set; } = eyeColor;
}

//Made by ericssonGamerz4