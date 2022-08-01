using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Formula.CommandTools
{
    public class CommandInfo
    {
        IList<CommandOption> _options = new List<CommandOption>();  
        IList<CommandArgument> _arguments = new List<CommandArgument>();

        public CommandInfo()
        {            
        }

        public string Name { get; set; }    
        public string Description { get; set; } 

        public string IsRoot { get; set; }  

        public IList<CommandOption> Options { get { return _options; } }   

       // public IList<CommandArgument> Arguments { get; set; }

        public bool HasOption(string optionName)
        {
           bool exists = false;

           var obj =  _options.FirstOrDefault(o => o.Name == optionName);
            if (obj != null)
            {
                exists = true;  
            }
           return exists;
        }
    }
}
