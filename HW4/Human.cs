using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Human
    {
        private string name;
        private string surname;
        private int age;

        public Human( string name, string surname, int age)
        {            
            Name = name;
            Surname = surname;
            Age = age;
        }

        [ColorAttribute(ConsoleColor.Blue)]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        [ColorAttribute(ConsoleColor.Green)]
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != "")
                {
                    surname = value;
                }
            }
        }
        
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }


    }
}
