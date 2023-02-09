using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._02._23_HW
{
    internal class Employee
    {
        private string Fullname { get; set; }
        private string Birthday { get; set; }
        private string Number { get; set; }
        private string Description { get; set; }
        private string Type { get; set; }
        private int Payday { get; set; }

        private static string Email;

        public Employee() { }
        public Employee(string fullname, string birthday, string number, string description, string type, int payday)
        {
            Fullname = fullname;
            Birthday = birthday;
            Number = number;
            Description = description;
            Type = type;
            Payday = payday;
        }
        static Employee()
        {
            Console.WriteLine("Введите почту: ");
            Email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Fullname: {Fullname}\nBirthday: {Birthday}\nNumber: {Number}\nEmail: {Email}\nDescription: {Description}\nType: {Type}\nPayment: {Payday}$");
        }
        public override string ToString()
        {
            return $"Fullname: {Fullname}\nBirthday: {Birthday}\nNumber: {Number}\nEmail: {Email}\nDescription: {Description}\nType: {Type}\nPayment: {Payday}$";
        }

        public static Employee operator+(Employee a, int b)
        {
            a.Payday += b;
            return a;
        }
        public static Employee operator-(Employee a, int b)
        {
            a.Payday -= b;
            return a;
        }
        public static bool operator==(Employee a, Employee b)
        {
            if(a.Payday == b.Payday)
                return true;
            else
                return false;
        }
        public static bool operator!=(Employee a, Employee b) => !(a == b);

        public static bool operator>(Employee a, Employee b)
        {
            if (a.Payday > b.Payday)
                return true;
            else
                return false;
        }
        public static bool operator<(Employee a, Employee b) => !(a.Payday > b.Payday);

    }
}
