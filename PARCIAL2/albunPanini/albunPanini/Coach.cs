using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albunPanini
{
    class Coach : Person
    {
        private DateTime startDate;
        private DateTime endDate;
        private string trayectory;


        public Coach(DateTime startDate, string firstName, string lastName, DateTime birthdayDate) : base(firstName, lastName, birthdayDate)
        {
            this.startDate = startDate;
        }

        public void getTime()
        {

        }
    }
}
