public static class SecretHandshake
{
    [Flags]
    public enum ActionsAvailable
    {
        Wink = 1,
        DoubleBlink = 2,
        CloseEyes = 4,
        Jump = 8,
        Reverse = 16
    };

    public static string[] Commands(int commandValue)
    {
        List<string> commands = new List<string>();

        ActionsAvailable actionsAvailable = (ActionsAvailable)commandValue;

        if (actionsAvailable.HasFlag(ActionsAvailable.Wink))     
            commands.Add("wink");
        
        if (actionsAvailable.HasFlag(ActionsAvailable.DoubleBlink))     
            commands.Add("double blink");
        
        if (actionsAvailable.HasFlag(ActionsAvailable.CloseEyes))
            commands.Add("close your eyes");
        
        if (actionsAvailable.HasFlag(ActionsAvailable.Jump))     
            commands.Add("jump");
        
        if (actionsAvailable.HasFlag(ActionsAvailable.Reverse))     
            commands.Reverse();    
        
        return commands.ToArray();
    }
}

//Made by ericssonGamerz4