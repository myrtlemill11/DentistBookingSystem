using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleBookingSystem.Data;

namespace consoleBookingSystem.Buisness
{
    public class Coordinator
    {
        private DAO dao;

        public Coordinator()
        {
            dao = new SQLDAOImplementation(); 
        }
    }
}
