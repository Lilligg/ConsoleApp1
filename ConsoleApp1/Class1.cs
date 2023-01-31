using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
            public string name;
            public int age;
            public void print() { Console.WriteLine($"Имя:{name} | Возраст {age}"); }
    }
}
