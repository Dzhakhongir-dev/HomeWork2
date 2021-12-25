using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork2
{
    class Program
    {
        static void Main(string[]args)
        {
            string fullName = (" ");
            byte age = 50;
            ushort height = 198;
            string email = (" ");
            float physicsPoints = 3.8f;
            float mathPoints = 3.8f;
            float ITPoints = 3.8f;
            double a = physicsPoints;
            double b = mathPoints;
            double c = ITPoints;

                                                                //#1 Задание

                                                                //Конкатенация Строк

            /*Console.WriteLine(fullName + age + height + email + physicsPoints + mathPoints + ITPoints);
             Console.ReadKey();*/

                                                                //Эскейп последовательность

            /*string pattern = ("Ф.И.О: {0} Возраст: {1} Рост: {2} Email: {3} Баллы по Физике: {4} Баллы по Математике {5} Баллы по IT {6}");
                Console.WriteLine(
                pattern,
                fullName,
                age,
                height,
                email,
                physicsPoints,
                mathPoints,
                ITPoints);*/

                                                                //Вывод в новой строке

            /*Console.WriteLine("\nФ.И.О.: {0} \nВозраст: {1} \nРост: {2} \nEmail: {3} \nБаллы по Физике: {4} \nБаллы по Математике: {5} \nБаллы по IT: {6}",
                fullName,
                age,
                height,
                email,
                physicsPoints,
                mathPoints,
                ITPoints);*/

                                                                //Интерполяция строк

            //Console.WriteLine($"Ф.И.О.:{fullName} Возраст:{age} Рост:{height} email:{email} Баллы по Физике:{physicsPoints} Баллы по Математике:{mathPoints} Баллы по IT:{ITPoints}");

                                                                //Форматированный вывод Строк

            //Console.WriteLine(Ф.И.О: + " " + Возраст: + " " + Рост: + " " + Email: + " " + БаллыпоФизике: + " " + БаллыпоМатематике: + " " + БаллыпоIT: + " ");


                                                                

                                                                //#2 Задание

            //var Summa = a + b + c;

            //Console.WriteLine(Summa = (physicsPoints + mathPoints + ITPoints));    //Сумма Баллов
            //Console.WriteLine(Summa = (a + b + c));                                //Сумма Баллов
            //Console.WriteLine(Summa = (a + b + c)/3);                              //Средний Балл

            /*string pattern = ("\nБаллы по Математике: {0},\nБаллы по Физике: {1},\nБаллы по IT:{2}, \nСумма всех баллов:{3} \nCредний арифметический балл:{4}");
            Console.WriteLine(
                pattern,
                a,
                b,
                c,
                (a + b + c),
                ((a + b + c)/3));*/





            Console.ReadKey();
        }
    }
}
