    public class Authenticator
    {
        private static Identity GetNewIdentity(string email, string eyeColor, decimal philtrumWidth, List<string> nameAndAddress)
        {
            return new Identity
            {
                Email = email,
                FacialFeatures = new FacialFeatures { EyeColor = eyeColor, PhiltrumWidth = philtrumWidth },
                NameAndAddress = nameAndAddress

            };
        }

        public Identity Admin => GetNewIdentity("admin@ex.ism", "green", 0.9M, ["Chanakya", "Mumbai", "India"]);

        public IDictionary<string, Identity> Developers => new Dictionary<string, Identity>
        {
            { "Bertrand", GetNewIdentity("bert@ex.ism", "blue",  0.8M, ["Bertrand", "Paris", "France"]) },
            { "Anders", GetNewIdentity("anders@ex.ism", "brown",  0.85M, ["Anders", "Redmond", "USA"])},
        };
    }

    //**** please do not modify the FacialFeatures class ****
    public class FacialFeatures
    {
        public required string EyeColor { get; set; }
        public required decimal PhiltrumWidth { get; set; }
    }

    //**** please do not modify the Identity class ****
    public class Identity
    {
        public required string Email { get; set; }
        public required FacialFeatures FacialFeatures { get; set; }
        public required IList<string> NameAndAddress { get; set; }
    }