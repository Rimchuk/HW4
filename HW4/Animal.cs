using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Animal
    {
        private string nickname;
        private string breed;
        private int age;
        private Human owner;

        public Animal(string nickname, string breed, int age, Human owner)
        {
            Nickname = nickname;
            Breed = breed;
            Age = age;
            Owner = owner;
        }

        [ColorAttribute(ConsoleColor.Red)]
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                if (value != "")
                {
                    nickname = value;
                }
            }
        }

        [ColorAttribute(ConsoleColor.Yellow)]
        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                if (value != "")
                {
                    breed = value;
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

        public Human Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }            
        }
    }
}
