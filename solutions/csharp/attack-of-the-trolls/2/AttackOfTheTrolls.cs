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

    public static bool Check(Permission current, Permission check) => current.HasFlag(check);
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
    None = 0,
    Read = 1 << 0,
    Write = 1 << 1,
    Delete = 1 << 2,
    All = Read | Write | Delete
}

//Made by ericssonGamerz4