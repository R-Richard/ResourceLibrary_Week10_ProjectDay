using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceLibrary_week10_projectDay
{
    class Resource
    {
        private string title;
        private string isbn;
        private int length;
        private string status;
        private int daysDue;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public int DaysDue
        {
            get { return this.daysDue; }
            set { this.daysDue = value; }
        }
        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }


      

        public virtual void AddTitle()
        {
          
            Console.WriteLine("\nEnter Title");
            Title = Console.ReadLine();
            Console.WriteLine("\nEnter ISBN");
            ISBN = Console.ReadLine();
            Console.WriteLine("\nEnter Length in Pages");
            Length = int.Parse(Console.ReadLine());
            Status = "Available";
           
        }
        public virtual void ViewTitle()
        {
            if (Title == null)
            {
                Console.WriteLine("No resource has been entered");
            }
            else
            {
                Console.WriteLine("Title: " + Title + "\nISBN: " + ISBN + "\nLength: " + Length + " pages\nStatus: " + Status);
            }
        }
        public virtual DateTime addDays()
        {
            int DaysDue = 3;
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(DaysDue);
            return answer;
        }

        public virtual void CheckOut()
        { 
            Status = "Checked Out";
            
            DateTime x = addDays(); 

            Console.WriteLine("\nYou have checked out " + Title + "\n" + Title + " is due back on " + addDays());
        }

        public virtual void CheckIn()
        {
            Status = "Checked In";
            Console.WriteLine("\n" + Title + "has been checked in");
        }

    }
}
