using System;

using wslctl.Models;

namespace wslctl
{
    internal static class Program
    {
        private static readonly Verb[] VerbList = new Verb[]
        {
            new Verb("start", "Start WSL Instance", "Start WSL instance.",
                "<str:instance-name>"),
            new Verb("shell", "Run WSL Shell", "Start distro's default shell interactively",
                "<str:instance-name>"),
            new Verb("list", "List WSL Instance", "Show installed WSL instances",
                "[flag:json]|[flag:yaml] [flag:compress]"),
        };

        [STAThread]
        private static void Main(string[] args)
        {
            Console.WriteLine("wslctl is under construction.");
        }
    }
}
