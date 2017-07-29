using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    [AttributeUsage(AttributeTargets.Property)]
    class ColorAttribute : System.Attribute
    {
        
        public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }

        public ConsoleColor Color { get; set; }

    }
}
