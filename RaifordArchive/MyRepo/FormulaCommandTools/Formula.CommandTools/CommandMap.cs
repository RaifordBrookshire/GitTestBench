using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Formula.CommandTools
{
    public class CommandMap
    {

        public IList<CommandInfo> _commands = new List<CommandInfo>();
        public IDictionary<string, ICommandHandler> _handlers = new Dictionary<string, ICommandHandler>();


        public void Add(CommandInfo commandInfo, ICommandHandler handler)
        {
            _commands.Add(commandInfo);
            _handlers.Add(commandInfo.Name, handler);



        }

        public CommandInfo GetCommand(string name)
        {
            return _commands.First<CommandInfo>(w => w.Name.ToUpper() == name.ToUpper());
        }

        public ICommandHandler GetHandler(string commandName)
        {
            ICommandHandler handler = _handlers[commandName];
            return handler;
        }
    }
}
