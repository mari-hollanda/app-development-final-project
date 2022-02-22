using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepEasyHotel.BusinessObjects
{
    class BookedServicesAddition
    {
       private static string CheckIn, CheckOut;
       private double costPerNight = 80.00;
        private double total;
       
       
        public BookedServicesAddition(string checkin, string checkout) 
        {
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public double CalculateTotal()
        {
            DateTime st = DateTime.Parse(CheckIn);
            DateTime end = DateTime.Parse(CheckOut);
            TimeSpan difference = end - st;
            
           return total = (difference.Days * costPerNight);
        }

       

        public override string ToString()
        {

            return "Total Cost Till Date: " + CheckOut + " is: " + CalculateTotal() + "\n";
                
        }
    }
}
