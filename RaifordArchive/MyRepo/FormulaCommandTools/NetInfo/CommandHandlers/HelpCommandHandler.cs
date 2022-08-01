using Formula.CommandTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NetInfo.CommandHandlers
{
    public class HelpCommandHandler : ICommandHandler
    {
       
        public void Execute(CommandInfo info)
        {
            Console.WriteLine($"Executing Command {this.GetType().Name} in console app.)");
            Debug.WriteLine($"Command Name: {info.Name}");

            //  info.Options.
            foreach (var o in info.Options)
            {
                Debug.WriteLine($"Option: {o.Name} -> {o.ShortName} -> {o.LongName}");

            }

            if (info.HasOption("help"))
            {
                Debug.WriteLine($"Contains Option: {"help"}");
            }

            Console.WriteLine($"Executing.........Command: {this.GetType().Name}");
            Debug.WriteLine($"Doing Work............");
        }
    }
}
