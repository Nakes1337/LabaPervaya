using System;

namespace LabaPervaya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAB1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Панин Илья");

            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };

            a.Add(b);

            b.Substract(a);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            Student Dima = new Student() { Age = 20, HairColor = "Брюнет", Sex = "Мужcкой", Name = "Дима" };
            Student Iltys = new Student() { Age = 20, HairColor = "Шатен", Sex = "Мужской", Name = "Илья" };

            Dima.MonsterStudent(Iltys);

            Console.WriteLine($"Name = {Dima.Name}\n" +
                $"Age = {Dima.Age}\n" +
                $"Sex = {Dima.Sex}\n" +
                $"Hair Color = {Dima.HairColor} ");
        }
    }
}
