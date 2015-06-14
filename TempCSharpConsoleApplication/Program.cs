using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempCSharpConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyToString(29031985));
            Console.WriteLine("2nd commit");
        }

        public static string MyToString(int number)
        {

            StringBuilder myNumber = new StringBuilder();
            while (number != 0)
            {
                var tempNumber = number % 10;
                number /= 10;
                switch (tempNumber)
                {
                    case 0:
                        myNumber.Insert(0, '0');
                        break;
                    case 1:
                        myNumber.Insert(0, '1');
                        break;
                    case 2:
                        myNumber.Insert(0, '2');
                        break;
                    case 3:
                        myNumber.Insert(0, '3');
                        break;
                    case 4:
                        myNumber.Insert(0, '4');
                        break;
                    case 5:
                        myNumber.Insert(0, '5');
                        break;
                    case 6:
                        myNumber.Insert(0, '6');
                        break;
                    case 7:
                        myNumber.Insert(0, '7');
                        break;
                    case 8:
                        myNumber.Insert(0, '8');
                        break;
                    case 9:
                        myNumber.Insert(0, '9');
                        break;

                }
            }
            return myNumber.ToString();
        }
    }
}
