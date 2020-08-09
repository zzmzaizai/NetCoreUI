using System;
using NetCoreUI.Linux;
using NetCoreUI.Example.App;

namespace NetCoreUI.Example.Linux
{
    class Program : ProgramBase
    {
        public static void Main(string[] args)
        {
            LinuxApplication.Init();
            Run();
        }
    }
}
