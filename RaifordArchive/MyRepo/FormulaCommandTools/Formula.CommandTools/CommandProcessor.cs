using System;

namespace Formula.CommandTools
{
    public class CommandProcessor
    {
        public void Execute(CommandInfo command)
        {
            // Load the Command based on the name
            ICommandHandler commandHandler = command as ICommandHandler;








        }

    }
}
