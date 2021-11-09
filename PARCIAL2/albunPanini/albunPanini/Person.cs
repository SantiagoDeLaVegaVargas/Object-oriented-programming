using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albunPanini
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int height;
        private string path;
        private DateTime birthdayDate;

        public Person(string firstName, string lastName, DateTime birthdayDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdayDate = birthdayDate; 
        }
        
        public int getAge()
        {
            int currentYear = DateTime.Now.Year;
            int year = birthdayDate.Year;

            return currentYear - year;
        }

        public string getFullName()
        {
            return "El nombre del jugador es :" + firstName + ' ' + LastName + ' ';
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public string Path
        {
            get => path;
            set => path = value;
        }

        public DateTime BirthdayDate
        {
            get => birthdayDate;
            set => birthdayDate = value;
        }

    }
}
