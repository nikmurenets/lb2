using System;

namespace Laboratorka2_7
{
    class Employee
    {
        public string name; //Имя
        public string surname; //Фамилия
        public static string dateOfHire; //Дата найма
        private OperateCost operationCost;// Должность


        private Employee(string name, string surname, string dateOfHire, OperateCost opCost)
        {
            this.name = name;
            this.surname = surname;
            Employee.dateOfHire = dateOfHire;
            this.operationCost = opCost;

        }
        //Коэффициент повышения вознаграждения в зависимости от даты найма, в днях
        public static double DiscoverGrade(string dateOfHire)
        {
            double dateValueForGrade = (DateTime.Now - DateTime.Parse(dateOfHire)).TotalDays;

            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
                return 1.1;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.5;
        }
        abstract class OperateCost
        {
            public double salary;
            public double tax;

            public abstract void ApplyBonus(double bonus, double grade);
            public abstract void ApplyTax();
        }

        class Slave : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (10000 + 2 * bonus) * grade;
            }

            public override void ApplyTax()
            {
                tax = salary * 0.34;
            }
        }

        class Warden : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (100000 + 5 * bonus) * grade;
            }
            public override void ApplyTax()
            {
                tax = salary * 0.34;
            }
        }

        class Lord : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (1000000 + 10 * bonus) * grade;
            }
            public override void ApplyTax()
            {
                tax = salary * 0.34;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                OperateCost oc = new Warden();
                Employee emp = new Employee("Ivan", "Ivanov", "12.03.2000", oc);
                double grade = Employee.DiscoverGrade("15.03.2002");
                Console.WriteLine("Name: {0}\nSurname: {1}\nDate of Hire: {2}\nPositoin: {3}", emp.name, emp.surname, Employee.dateOfHire, emp.operationCost);
                oc.ApplyBonus(25000, grade);
                oc.ApplyTax();
                Console.WriteLine("Salary: {0}\nTax: {1}", emp.operationCost.salary, emp.operationCost.tax);
                Console.ReadKey();
            }
        }
    }
}
