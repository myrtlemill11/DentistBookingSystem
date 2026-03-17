using System;
using System.Collections.Generic;
using consoleBookingSystem.Buisness;

namespace consoleBookingSystem.Presentation
{
    public class View
    {
        Coordinator coord;

        public View()
        {
            coord = new Coordinator();
        }

        public void startUI()
        {
            MainUI ui = new MainUI();
            ui.start();
        }
    }
}