public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }
    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object? obj) => obj is FacialFeatures face && EyeColor == face.EyeColor && PhiltrumWidth == face.PhiltrumWidth;
    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }
    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public override bool Equals(object? obj) => obj is Identity other && Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures.GetHashCode());
}

public class Authenticator
{
    private readonly HashSet<Identity> _identitySet = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);
    public bool IsAdmin(Identity identity)
    {
        var admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
        return admin.Equals(identity);
    }
    public bool Register(Identity identity) => _identitySet.Add(identity);
    public bool IsRegistered(Identity identity) => _identitySet.TryGetValue(identity, out _);
    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}