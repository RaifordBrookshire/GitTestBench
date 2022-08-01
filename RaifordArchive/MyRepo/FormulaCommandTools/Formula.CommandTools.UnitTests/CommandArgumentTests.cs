using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;
using System.Diagnostics;

namespace Formula.CommandTools.UnitTests
{







    public class CommandArgumentTests
    {
        [Fact]
        public void Basic_Usage()
        {
            CommandMap commandMap = new CommandMap();

            // Register Commands to Map
            string COMMAND_NAME = "help";
            CommandInfo info = new CommandInfo() { Name = COMMAND_NAME, Description = "My cool command Description" };
            info.Options.Add(new CommandOption() { Name = "verbose" });
            info.Options.Add(new CommandOption() { Name = "detail" });
            info.Options.Add(new CommandOption() { Name = "show" });
            commandMap.Add(info, new HelpCommandHandler());
            var help = commandMap.GetCommand(COMMAND_NAME);

           // var map =

            // Simulate args passed into main

            //string[] args = { "help", "-h", "--help" };
            //CommandInfo currentCommand = commandMap.GetCommand(args[0] as string);

            // You have the current Command so process it
            //ICommandHandler handler = commandMap.GetHandler(currentCommand.Name);
            //handler.Execute();

            return;

            //CommandProcessor processor = new CommandProcessor();
            //processor.Execute(currentCommand);




            // Search for Command
            // commandMap.Get()









            //CommandProcessor processor

            // var builder = CommandBuilder(string[] args);

            //var info = new CommandInfo(args);

            //CommandProcessor processor = new CommandProcessor();    
            //processor.Execute()

        }

        [Fact]
        public void Basic_Usage2()
        {
            // Get the Command from args

            // Get the Command Options

            // using the Command name pull the handler

            // Command.Execute(options)




        }



        [Fact]
        public void CommandHandler_Usage()
        {
            // Setup the CommandInfo structure
            CommandInfo info = new CommandInfo() { Name = "help", Description = "My cool command Description" };
            info.Options.Add(new CommandOption() { Name = "", ShortName="h", LongName="help" });
            // info.Options.Add(new CommandOption() { Name = "detail" });
            // info.Options.Add(new CommandOption() { Name = "show" });


            Debug.WriteLine($"Command Name: {info.Name}");

            //  info.Options.
            foreach(var o in info.Options)
            {
                Debug.WriteLine($"Option: {o.Name} -> {o.ShortName} -> {o.LongName}");

            }

            if(info.HasOption("help"))
            {
                Debug.WriteLine($"Contains Option: {"help"}");
            }

            Debug.WriteLine($"Doing Work............");



        }

        [Fact]
        public void ParseCommandTest()
        {
            // Simulate command line args
            string[] args = { "help", "-h", "--help" };


            // Command from Registered Command
            CommandInfo infoRegisterd = new CommandInfo { Name = "help" };
            infoRegisterd.Options.Add(new CommandOption() { Name = "help", ShortName="h", LongName="help" });



            // Command from Command Line ARgs
            CommandInfo info = new CommandInfo();
            info.Name = args[0];

            for(int i = 1; i < args.Length; i++)
            {
                string a = args[i];

                if(a.StartsWith("-"))
                {
                    if(a.StartsWith("--"))
                    {
                        info.Options.Add(new CommandOption { LongName = a.Substring(2) });
                    }
                    else
                    {
                        info.Options.Add(new CommandOption { ShortName = a.Substring(1)});
                    }
                }
            }


            // Lookup partial option data and populate the option fully
           foreach(CommandOption o in info.Options)
            {
                var registerdOption = infoRegisterd.Options.FirstOrDefault<CommandOption>(cmd => cmd.ShortName == o.ShortName || cmd.LongName == o.LongName);
                if(registerdOption==null)
                {
                    // Invalid Option for this command
                }
                else
                {
                    o.Name = registerdOption.Name;
                    o.ShortName = registerdOption.ShortName;
                    o.LongName = registerdOption.LongName;                   
                }
            }

           // We now have a fully populate Options object in the commandInfo


        }
    }
}
