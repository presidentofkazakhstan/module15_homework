using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace module15_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            Type console = typeof(Console);
            MethodInfo[] methods = console.GetMethods();
            Console.WriteLine("Методы класса Console: ");
            foreach (MethodInfo methodinfo in methods)
            {
                Console.Write(methodinfo.ReturnType.Name + "\t" + methodinfo.Name);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Второе задание");

            Man man = new Man()
            {
                Name = "Muratzhan",
                Age = 16,
                City = "Nursultan"
            };
            Type type = typeof(Man);
            Console.WriteLine("Тип: " + type.Name);
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Методы: ");
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + ":\t" + property.Name);
            }
            Console.ReadKey();
        }
    }
}
