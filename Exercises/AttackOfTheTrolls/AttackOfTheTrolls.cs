namespace Exercism_Exercises.Exercises.AttackOfTheTrolls;

static class Permissions
{
    public static Permission Default(AccountType accountType) => accountType switch
    {
        AccountType.Guest => Permission.Read,
        AccountType.User => Permission.Write | Permission.Read,
        AccountType.Moderator => Permission.All,
        _ => Permission.None,
    };

    public static Permission Grant(Permission current, Permission grant) => current | grant;

    public static Permission Revoke(Permission current, Permission revoke) => current & ~revoke;

    public static bool Check(Permission current, Permission check) => (current & check) == check;
}

enum AccountType
{
    Guest,
    User,
    Moderator,
}

[Flags]
enum Permission
{
    None = 0b0000,
    Read = 0b0001,
    Write = 0b0010,
    Delete = 0b0100,
    All = 0b0111,
}

//Made by ericssonGamerz4