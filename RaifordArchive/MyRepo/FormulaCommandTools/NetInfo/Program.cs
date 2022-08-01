using Formula.CommandTools;
using System;

namespace NetInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandProcessor processor = new CommandProcessor();
            CommandBuilder builder = new CommandBuilder();

            var commandInfo =  builder.Build(args);


            
            processor.Execute(commandInfo);







            //foreach(string arg in args)
            //{
            //    Console.WriteLine(arg); 
            //}

            //var line =Environment.CommandLine;
            //Console.WriteLine(line);
            //var lineArgs = Environment.GetCommandLineArgs();

            //foreach(string a in lineArgs)
            //{
            //    Console.WriteLine(a);
            //}

            Console.Read();


            Console.WriteLine("Thanks....");
        }
    }
}
