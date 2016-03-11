using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ResourceLibrary_week10_projectDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource resourceInfo = new Resource();
            DVD dvdInfo = new DVD();
            Book bookInfo = new Book();
            Magazine magazineInfo = new Magazine();

            bool restart = true;
          while(restart==true)
            {
                Header();
                {
                    Console.WriteLine("\nEnter Menu Item Number");
                    string menuItem = Console.ReadLine();
                    string menuItemTemp;
                    int userInput;
                    userInput = NumberCheck(menuItem);
                    int caseRestart = 0;
                    while (caseRestart == 0)
                    {
                        switch (userInput)
                        {
                            case 1:
                                do
                                {
                                    Console.Clear();
                                    Header();
                                    Console.WriteLine("DVD Options\na: Add Item\nb: View Item\nc: Check Item Out\nd: Check Item In");
                                    menuItemTemp = Console.ReadLine();
                                    menuItem = menuItemTemp.ToLower();
                                    Console.Clear();
                                    Header();
                                    switch (menuItem)
                                        {
                                            case "a":
                                            do
                                            {
                                                dvdInfo.AddTitle();
                                                Console.Clear();
                                                Header();
           
                                                userInput = DoNext(menuItem);
                                              
                                                break;
                                            }
                                            while (menuItem == "a");
                                            break;      

                                        case "b":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                dvdInfo.ViewTitle();

                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "b");
                                            break;

                                           
                                        case "c":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                dvdInfo.CheckOut();
                                              
                                                userInput = DoNext(menuItem);
                                                break;
                                    }
                                    while (menuItem == "c") ;
                                    break;
                                           
                                    case "d":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                dvdInfo.CheckIn();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "d");
                                            break;
                                    }

                                }
                                while (userInput == 1);
                                break;





                            case 2:
                                do
                                {
                                    Console.Clear();
                                    Header();
                                    Console.WriteLine("Book Options\na: Add Item\nb: View Item\nc: Check Item Out\nd: Check Item In");
                                    menuItemTemp = Console.ReadLine();
                                    menuItem = menuItemTemp.ToLower();
                                    Console.Clear();
                                    Header();
                                    switch (menuItem)
                                    {
                                        case "a":
                                            do
                                            {
                                                bookInfo.AddTitle();
                                                Console.Clear();
                                                Header();

                                                userInput = DoNext(menuItem);

                                                break;
                                            }
                                            while (menuItem == "a");
                                            break;

                                        case "b":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                bookInfo.ViewTitle();

                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "b");
                                            break;


                                        case "c":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                bookInfo.CheckOut();

                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "c");
                                            break;

                                        case "d":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                bookInfo.CheckIn();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "d");
                                            break;
                                    }

                                }
                                while (userInput == 2);
                                break;



                            case 3:
                                do
                                {
                                    Console.Clear();
                                    Header();
                                    Console.WriteLine("DVD Options\na: Add Item\nb: View Item\nc: Check Item Out\nd: Check Item In");
                                    menuItemTemp = Console.ReadLine();
                                    menuItem = menuItemTemp.ToLower();
                                    Console.Clear();
                                    Header();
                                    switch (menuItem)
                                    {
                                        case "a":
                                            do
                                            {
                                                magazineInfo.AddTitle();
                                                Console.Clear();
                                                Header();

                                                userInput = DoNext(menuItem);

                                                break;
                                            }
                                            while (menuItem == "a");
                                            break;

                                        case "b":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                magazineInfo.ViewTitle();

                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "b");
                                            break;


                                        case "c":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                magazineInfo.CheckOut();

                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "c");
                                            break;

                                        case "d":
                                            do
                                            {
                                                Console.Clear();
                                                Header();
                                                magazineInfo.CheckIn();
                                                userInput = DoNext(menuItem);
                                                break;
                                            }
                                            while (menuItem == "d");
                                            break;

                                        default:
                                            {
                                                Console.WriteLine("\nThat is not a Valid Entry");
                                                userInput = DoNext(menuItem);
                                                Console.Clear();
                                                Header();

                                                break;
                                            }
                                    }
                                }
                                while (userInput == 3);
                                break;

                            case 4:
                                do

                                {
                                    Console.Clear();
                                    Header();
                                    Console.WriteLine("Magazine Info");
                                    magazineInfo.ViewTitle();
                                    Console.WriteLine();
                                    Console.WriteLine("DVD Info");
                                    dvdInfo.ViewTitle();
                                    Console.WriteLine();
                                    Console.WriteLine("Book Info");
                                    bookInfo.ViewTitle();

                                    userInput = DoNext(menuItem);
                                    break;
                                }
                                while (userInput == 4);
                                    break;

   


                            case 5://Exit
                                {
                                    Console.WriteLine("\nAre you sure you want to exit? \nPress \"N\" to restart program\nPress any other key to exit");
                                    string restartAsString = Console.ReadLine();

                                    if (restartAsString.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        caseRestart++;
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        restart = false;
                                        Console.Clear();
                                        Console.WriteLine("GoodBye");
                                        Thread.Sleep(1000);
                                        Environment.Exit(0);
                                    }
                                    break;

                                }
                            default:
                                {
                                    Console.WriteLine("\nThat is not a Valid Entry");
                                    userInput = DoNext(menuItem);
                                    Console.Clear();
                                    Header();

                                    break;
                                }
                        }
                    }
                }
            }
        }
              // //////////////////////////////////////////////////////////////////////////////////////////////


                static void Header()
        {
            // Console.Clear();
            string title = "RESOURCES CHECKOUT/CHECKIN MENU";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title + "\n\n", Console.Title);

   
            Console.WriteLine("Choose a Resource Type\n1: DVD\n2: Book\n3: Magazine\n4: View All Item Status\n5: Exit");
            StringBldrLine();
        }
        //////////////////////////////////////////StringBldrLine METHOD/////////////////////////////////////////////////////////////////
        static void StringBldrLine()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*");
            for (int i = 1; i <= 79; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine(sb);
        }
                ///////////////////////////////////////////////////////////////////Number Check Method///////////////////////////////////////////

                static int NumberCheck(string input)
        {
                    int menuItem;

                    do
                    {

                        bool numVer = int.TryParse(input, out menuItem);
                        if ((menuItem != 0))
                        {
                            return menuItem;
                        }
                        else if (menuItem == 0)
                        {
                            Console.WriteLine("That is not a valid entry, please enter a number");
                            input = Console.ReadLine();
                        }
                    }
                    while (menuItem == 0);
                    return menuItem;
                }
                //////////////////////////////////////////Do Next METHOD/////////////////////////////////////////////////////////////////
                static int DoNext(string menuItem)

        {
                    int userInput;
                    Console.WriteLine("\nWhat would you like to do next? Choose a Resource Type From the Menu:");
                    menuItem = Console.ReadLine();

                    userInput = NumberCheck(menuItem);

                    return userInput;

                }



    }
        }
