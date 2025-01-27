using System.Drawing;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        #region
        #endregion


        enum weekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday , Sunday

        }

        struct person
        {
            public string name;
            public int age;
        }

        enum season
        {
            winter , summer,autumn,spring
        }
        enum colors
        {
            red, green, blue
        }

        [Flags]
        enum permission
        {
            read = 1,
            write = 2,
            delete = 3,
            execute= 4,



             
            
        }


        struct point
            { 
            public double x; 
            public double y;

            public point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double distance(point p)
            {
                return Math.Sqrt(Math.Pow(x - p.x, 2)+ Math.Pow(y - p.y, 2));
            }
        }




        static void Main(string[] args)
        {
            #region Q1
            foreach (weekDays day in Enum.GetValues(typeof(weekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion


            #region Q2
            person[] people = new person[3];
            people[0] = new person {name = "ahmed", age = 20 };
            people[0] = new person { name = "ali", age = 23 };
            people[0] = new person { name = "mohamed", age = 40 };
            foreach (var person in people)
            {
                Console.WriteLine($"name:{person.name},age : {person.age}");
                
            }

            #endregion

            #region Q3
            Console.WriteLine("enter the season:");
            string input = Console.ReadLine();
            season season;

            if (Enum.TryParse(input, true, out season))
            {
                switch (season)
                {
                    case season.winter:
                        Console.WriteLine("december to february");
                        break;
                    case season.summer:
                        Console.WriteLine("june to augast");
                        break;
                    case season.autumn:
                        Console.WriteLine("septemper to novamber");
                        break;
                    case season.spring:
                        Console.WriteLine("");
                        break;


                }
            }
            #endregion

            #region Q4
            permission mypermissions = permission.read;
            mypermissions ^= permission.write;
            mypermissions ^= permission.read;
            mypermissions |= permission.delete;
            if ((permission.read & mypermissions) == permission.read)
            {
                Console.WriteLine(mypermissions);
            }
            Console.WriteLine(mypermissions);

            #endregion

            #region Q5
            Console.WriteLine("enter a color :");
            string input1 = Console.ReadLine();
            colors color;
            if (Enum.TryParse(input1, true, out color))
            {
                Console.WriteLine($"{color}is a primary color");
            }
            else
            {
                Console.WriteLine($"{input} is not a primary color ");
            }

            #endregion

            #region Q6

            Console.WriteLine("Enter coordintaes for point 1 ");
            var p1 = new point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter coordintaes for point 2 ");
            var p2 = new point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine($"The distance between the two points is {p1.distance(p2)}");

            #endregion



        }
    }
}
