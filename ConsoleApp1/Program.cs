using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*var fedya = new Student("Игорь Птицын Евгеньевич", "ТАКСЕБЕТИПСЫ-07-228", 5);
            fedya.ShowScreen();
            fedya.ChangeGroup("НОРМТИПСЫ-07-23");
            fedya.CourseUp();
            Console.WriteLine(" ");
            fedya.ShowScreen();
            Console.WriteLine(" ");
            Console.ReadKey();*/

            /*Computer computer = new Computer("GGGGGG", "OOOOOO", 8);
            Console.WriteLine();
            computer.ChangeMam("IIIIIIIII");
            Console.WriteLine();
            computer.ChangeMemValue(25);
            Console.WriteLine();


            Computer computer1 = new Computer();
            Console.WriteLine();
            computer1.ChangeMam("IIIIIIIII");Console.WriteLine();
            Console.WriteLine();
            computer1.ChangeMemValue(25);
            Console.ReadKey();*/


            SCUMShopping shopping = new SCUMShopping("Алиев Ильхам Гейдар оглы", 100000000);
            shopping.Cost = 100;
            shopping.Cost = 100;
            shopping.Cost = 100;
            shopping.Cost = 100;
            shopping.Cost = 100;
            shopping.Cost = 1000000;
            shopping.Cost = 100;
            shopping.Cost = 100;
            shopping.Cost = 100;
            shopping.Cost = 100;
            shopping.Cost = 100;
            Console.ReadKey();
            
        }

        class SCUMShopping
        {
            string name;
            int moneyCount;
            int shopCounts;

            public SCUMShopping(string name, int moneyCount)
            {
                this.name = name;
                this.moneyCount = moneyCount;
                this.shopCounts = 0;
                DisplayShow();
            }

            private void DisplayShow()
            {
                Console.WriteLine(name);
                Console.WriteLine(moneyCount);
                Console.WriteLine(shopCounts);
            }

            public int Cost
            {
                get { return shopCounts; }

                set { if (moneyCount - value >= 0) 
                    {
                        shopCounts++;
                        this.moneyCount -= value;
                        DisplayShow();
                    }
                    else
                    {
                        Console.WriteLine("нет денег");
                    }
                }
            }
        }

        class Computer
        {
            string proc;
            string mam;
            float mem;

            public Computer(string proc, string mam, int mem)
            {
                this.proc = proc;
                this.mam = mam;
                this.mem = mem;
                ShowDisplay();
            }

            public Computer()
            {
                this.proc = "I7 11700KF";
                this.mam = "mam0750-4";
                this.mem = 8;
                ShowDisplay();
            }

            public void ChangeMam(string mama)
            {
                this.mam = mama;
                Console.WriteLine("Материнка изменена");
                ShowDisplay();
            }

            public void ChangeMemValue(float x)
            {
                Console.WriteLine("Память изменена");
                if ((x > 0) && (x < 100))
                {
                    this.mem += this.mem * (x / 100);
                    ShowDisplay();
                }
            }

            private void ShowDisplay()
            {
                Console.WriteLine("Процессор - " + proc);
                Console.WriteLine("Материнка - " + mam);
                Console.WriteLine("Память = " + Convert.ToString(mem));
            }
            
        }

        class Student
        {
            string NSM;
            string group;
            int course;

            public Student(string NSM, string group, int course)
            {
                this.NSM = NSM;
                this.group = group;
                this.course = course;
            }

            public void ShowScreen()
            {
                Console.WriteLine(NSM);
                Console.WriteLine(group);
                if (course >= 5)
                {
                    Console.WriteLine("Отчислен!");
                }
                else
                {
                    Console.WriteLine("Курс - " + Convert.ToString(course));
                }
            }

            public void ChangeGroup(string ChangeGroup)
            {
                this.group = ChangeGroup;
            }

            public void CourseUp()
            {
                this.course++;
            }
        }
    }
}
