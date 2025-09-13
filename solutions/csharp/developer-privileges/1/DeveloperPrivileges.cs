public class Authenticator
{
    public Identity Admin
    {
        get
        {
            return new Identity
            {
                Email = "admin@ex.ism",
                FacialFeatures = new FacialFeatures { EyeColor = "green", PhiltrumWidth = (decimal)0.9 },
                NameAndAddress = ["Chanakya", "Mumbai", "India"]

            };
        }
    }

    public IDictionary<string, Identity> Developers
    {
        get
        {
            return new Dictionary<string, Identity>
            {
                {
                    "Bertrand",
                    new Identity
                    {
                        Email = "bert@ex.ism",
                        FacialFeatures = new FacialFeatures { EyeColor = "blue", PhiltrumWidth = (decimal)0.8 },
                        NameAndAddress = ["Bertrand", "Paris", "France"]
                    }
                },
                {
                    "Anders",
                    new Identity
                    {
                        Email = "anders@ex.ism",
                        FacialFeatures = new FacialFeatures { EyeColor = "brown", PhiltrumWidth = (decimal)0.85 },
                        NameAndAddress = ["Anders", "Redmond", "USA"]
                    }
                },

            };
        }
    }
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