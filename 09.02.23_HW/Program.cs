using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._02._23_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Nikita", "10.02.2004", "+380631140207", "CEO", "Main Proger", 2300);
            Employee employee2 = new Employee("Dima", "22.07.2004", "+380955053116", "CO-CEO", "Proger", 2000);
            Console.WriteLine(employee1);
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine("\n\n");
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();
            Console.WriteLine(matrix1);
            Console.WriteLine("\n"+matrix2);
            matrix1 = matrix1 + matrix2;
            Console.WriteLine("\n" + matrix1);
            matrix1 = matrix1 * matrix2;
            Console.WriteLine("\n" + matrix1);
        }
    }
}
