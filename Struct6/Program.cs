using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct6
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int task;
                Console.WriteLine("Enter task 1-6   ");
                int.TryParse(Console.ReadLine(), out task);
                switch (task)
                {
                    case 1:
                        Notebook noteBook = new Notebook("testModel", "testProducer", 1234);
                        noteBook.Show();
                        break;
                    case 2:
                        Train[] train = new Train[2];

                        for (int i = 0; i < train.Length; i++)
                        {                           
                            int numberTrain;
                            Console.WriteLine("Enter number train:");
                            int.TryParse(Console.ReadLine(), out numberTrain);

                            Console.WriteLine("Enter distination:");
                            string destination = Console.ReadLine();

                            Console.WriteLine("Enter time (hh:mm):");
                            //DateTime departTime = new DateTime(14,50,60);
                            TimeSpan departTime = new TimeSpan();
                            string timeString = Console.ReadLine();
                            TimeSpan.TryParse(timeString,out departTime);

                            train[i].AddTrain(destination, numberTrain, departTime);                            
                        }

                        Array.Sort(train, new Comparison<Train>((a,b)=>a.numberTrain.CompareTo(b.numberTrain)));
                        for (int i = 0; i < train.Length; i++)
                        {
                            Console.WriteLine(train[i].ToString());
                        }
                        Console.WriteLine("Enter number train for search:");
                        int searchNumber;
                        int.TryParse(Console.ReadLine(), out searchNumber);
                        Train gettedTrainByNumber = Array.Find(train, tr => tr.numberTrain == searchNumber);
                        if (gettedTrainByNumber.numberTrain != 0)
                        {
                            Console.WriteLine(gettedTrainByNumber);
                        }
                        else
                            Console.WriteLine("Train not found");

                        break;
                    case 3:
                        MyClass myClass = new MyClass();
                        MyStruct myStruct;

                        myClass.change = "не изменено";
                        myStruct.change = "no changed";

                        Program.ClassTaker(myClass);
                        Program.StructTaker(myStruct);

                        Console.WriteLine(myClass.change);
                        Console.WriteLine(myStruct.change);

                        break;
                    case 4:
                        Console.WriteLine("Enter your birth date (yyyy/mm/dd):");
                        DateTime birthDate;

                        if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                        {
                            birthDate = new DateTime(DateTime.Today.Year, birthDate.Month, birthDate.Day);
                            TimeSpan resultDays;

                            birthDate = DateTime.Today.DayOfYear > birthDate.DayOfYear ? birthDate.AddYears(1) : birthDate;
                            resultDays = birthDate - DateTime.Today;
                            Console.WriteLine("{0} - days to next birthday", resultDays.Days);
                        }
                        else
                            Console.WriteLine("{0}' is not in an acceptable format.", birthDate);
            
                        break;

                    case 5:
                        Console.WriteLine("Enter string:");
                        string stroka = Console.ReadLine();
                        Console.WriteLine("Enter color (0 - green, 1 - yellow, 2 - blue):");
                        int colorNumber;
                        int.TryParse(Console.ReadLine(), out colorNumber);
                        ColorPrinter.Print(stroka, colorNumber);

                        break;
                    case 6:
                        Accauntant accautant = new Accauntant();
                        foreach (Post p in Enum.GetValues(typeof(Post)))    
                        {
                            if (accautant.AskForBonus(p, 170))
                                Console.WriteLine("Выдать премию для {0}", p.ToString());
                            else
                                Console.WriteLine("Не выдавать премию для {0},", p.ToString());
                        }
                        
                        accautant.AskForBonus(Post.manager, 150);
                        accautant.AskForBonus(Post.secretary, 150);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                      
                }
                
             }
            
        }
    }
}
