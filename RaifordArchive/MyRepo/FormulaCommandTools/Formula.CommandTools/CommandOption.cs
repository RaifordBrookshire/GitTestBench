using System;
using System.Collections.Generic;
using System.Text;

namespace Formula.CommandTools
{
    public class CommandOption
    {

        public CommandOption(string name="", string shortName = "", string longName = "")
        {

        }
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string LongName { get; set; }


      //  public IList<string> Aliases { get; set; }
    }
}
