using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class PrintColor
    {
        public void ColorPrint(object obj)
        {
            Type type = obj.GetType();
            foreach (PropertyInfo info in type.GetProperties())
            {
                if (info.IsDefined(typeof(ColorAttribute)))
                {
                    ColorAttribute colorAttribute = info.GetCustomAttribute(typeof(ColorAttribute)) as ColorAttribute;
                    Console.ForegroundColor = colorAttribute.Color;
                    Console.WriteLine(info.GetValue(obj));
                    Console.ResetColor();

                }
                else
                {
                    Console.WriteLine(info.GetValue(obj));
                }
            }
        }
    }
}
