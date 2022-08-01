using System;

namespace Formula.CommandTools
{
    public class CommandHandlerAttribute : Attribute
    {
        public string Name { get; set; }

        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Description { get; set; }


        public CommandHandlerAttribute(string name="", string shortName="", string longName="", string description="")
        {
            Name = name;
            ShortName = shortName;
            LongName = longName;
            Description = description;    

        }
    }
}