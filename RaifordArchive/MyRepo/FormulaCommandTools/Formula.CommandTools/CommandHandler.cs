using System;
using System.Collections.Generic;
using System.Text;

namespace Formula.CommandTools
{

    [CommandHandlerAttribute(Name="Help", Description ="This is the DESCRIPTION")]
    public class CommandHandler : ICommandHandler
    {
        public virtual void Execute(CommandInfo commandInfo)
        {
            throw new InvalidOperationException("You must derive a class from CommandHandler");
        }
    }
}
