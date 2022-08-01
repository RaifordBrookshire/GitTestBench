using System;
using System.Collections.Generic;
using System.Text;

namespace Formula.CommandTools
{
    public class CommandBuilder
    {
        public CommandInfo Build(string[] args)
        {
            CommandInfo info = new CommandInfo();

            // Get Command name
            // The first argument should be the command name
            string arg1 = args[0];
            arg1 = arg1.Trim(); 
           







            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                {
                    info.Name = args[0];
                }
                if (i == 1)
                {
                    //if (IsSingleOption(arg[i])
                    //{
                    //    info.Options.Add(args[i]);
                    //}
                    //if (IsCompoundOption(args[i]))
                    //{

                    //}






                }



            }
            // Get Command Name

            return info;
        }

        private bool IsSingleOption(string arg )
        {
            arg = arg.Trim();

            if (arg.StartsWith("-") && arg.Length == 2)
                return true;
            return false;

        }
        private bool IsCompoundOption(string arg)
        {
            if (arg.StartsWith("-"))
                return true;
            return false;

        }




    }
}
