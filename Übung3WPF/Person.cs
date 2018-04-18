using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung3WPF
{
    class Person
    {
        private String vorname;
        private String nachname;
        private int alter;
        private String haustier;

        public Person()
        {

        }
        public Person(String vorname, String nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }

        public int Alter
        {
            get
            {
                return alter;
            }
        }
        public string Haustier
        {
            get
            {
                return haustier;
            }

            set
            {
                haustier = value;
            }
        }

        public void Geburtstag()
        {

        }
    }
}
