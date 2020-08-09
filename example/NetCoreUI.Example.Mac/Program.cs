using System;
using NetCoreUI.Mac;
using NetCoreUI.Example.App;

namespace NetCoreUI.Example.Mac
{
    class Program : ProgramBase
    {
        public static void Main(string[] args)
        {
            MacApplication.Init();
            Run();
        }
    }
}
