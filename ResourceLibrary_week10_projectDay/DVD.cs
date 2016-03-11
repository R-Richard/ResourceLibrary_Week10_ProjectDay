using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceLibrary_week10_projectDay
{
    class DVD : Resource
    {
     //   int DaysDue = 5;
        public override void ViewTitle()
        {
            if (Title == null)
            {
                Console.WriteLine("No resource has been entered");
            }
            else
            {
                Console.WriteLine("Title: " + Title + "\nISBN: " + ISBN + "\nLength: " + Length + " minutes\nStatus: " + Status);
            }
        }

        public override void AddTitle()
        {
            Console.WriteLine("\nEnter Title");
            Title = Console.ReadLine();
            Console.WriteLine("\nEnter ISBN");
            ISBN = Console.ReadLine();
            Console.WriteLine("\nEnter Length in Minutes");
            Length = int.Parse(Console.ReadLine());
            Status = "Available";
        }

        }
    }

    

