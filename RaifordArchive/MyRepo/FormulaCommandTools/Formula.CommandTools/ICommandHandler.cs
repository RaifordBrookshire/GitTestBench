using System;
using System.Collections.Generic;
using System.Text;

namespace Formula.CommandTools
{
   public interface ICommandHandler
    {
        void Execute(CommandInfo commandInfo);
    }
}
