using consoleBookingSystem.Presentation;
using System;

namespace consoleBookingSystem
{
    public class ApplicationRunner
    {
        static void Main(string[] args)
        {
            MainUI ui = new MainUI();
            ui.Start();
        }
    }
}
