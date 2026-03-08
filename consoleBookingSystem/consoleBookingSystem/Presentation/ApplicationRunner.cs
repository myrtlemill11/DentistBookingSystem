using consoleBookingSystem.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consoleBookingSystem
{
    public class ApplicationRunner
    {
        static void Main(string[] args)
        {
            View v = new View();
            v.startUI();
        }
    }
}
