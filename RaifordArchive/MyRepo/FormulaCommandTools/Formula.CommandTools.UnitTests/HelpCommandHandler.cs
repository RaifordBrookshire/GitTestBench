using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Formula.CommandTools.UnitTests
{
    [CommandHandler(Name="Help", ShortName="h", LongName="help", Description="This is a description of Command")]
    public class HelpCommandHandler : CommandHandler
    {
        public override void Execute(CommandInfo info)
        {

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
