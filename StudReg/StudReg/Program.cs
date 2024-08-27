using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudReg
{
    internal class Program
    {
        static char choose;
        static void Main(string[] args)
        {
            string directorPath = @"C:\Users\PC\Documents\Requirements";

            string[] filesToCheck = { 
                "GoodMoral.pdf",
                "form137.pdf","grades.xlsx"
            };

            foreach (string fileName in filesToCheck) { 
                string filePath = Path.Combine(directorPath, fileName);
                if (File.Exists(filePath))
                {
                    Console.WriteLine($"File {fileName} exists");
                }
                else {
                    Console.WriteLine($"File {fileName} does not exist");
                }
                {
                    
                }
            }
            bool isRunning = false;
            while (!isRunning)
            {
                Console.Write("Do you want to enroll (y/n)? ");
                choose = Convert.ToChar(Console.ReadLine());

                if (choose == 'y' || choose == 'Y')
                {

                    Console.WriteLine("The tuition for this enrollment is P 32,000 ");
                    Console.Write("Money Budget: ");

                    double money = Convert.ToDouble(Console.ReadLine());

                    if (money >= 32000)
                    {
                        Console.WriteLine("You have enough money");
                        Console.WriteLine();
                        Console.WriteLine("Requirements: \n1. Form 137\n2. Good Moral\n3. PSA\n4. Medical Certification");
                        Console.WriteLine();

                        Console.Write("What requirements do you have? ");
                        string reqchoice = Console.ReadLine();

                        if (reqchoice.Contains("1") && reqchoice.Contains("2") && reqchoice.Contains("3") && reqchoice.Contains("4"))
                        {
                            Console.WriteLine("You can enroll now!");
                        }
                        else {
                            Console.WriteLine("Sorry, You cant enroll.");
                            continue;
                        }

                        break;

                    }
                    else if (money < 32000)
                    {
                        Console.WriteLine("Try again with enough budget.");
                        continue;
                    }
                }
                else if (choose == 'n' || choose == 'N')
                {
                    Console.WriteLine("Thank you for trying!");
                    break;
                }
            }
        }
    }
}
