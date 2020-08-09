using System;
using NetCoreUI.Win;
using NetCoreUI.Example.App;

namespace NetCoreUI.Example.Win
{
    class Program : ProgramBase
    {
        [STAThread]
        public static void Main(string[] args)
        {
            WindowsApplication.Init();
            Run();
        }
    }
}
