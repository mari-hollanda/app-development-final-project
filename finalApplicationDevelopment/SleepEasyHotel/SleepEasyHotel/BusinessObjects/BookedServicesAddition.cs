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
       
       
        public BookedServicesAddition() 
        {
            
        }

        public double CalculateTotal(string checkin, string checkout)
        {
            CheckIn = checkin;
            CheckOut = checkout;
            if (checkin == "" || checkout == "")
                {
                return 0;
            }
            else 
            {
                DateTime st = DateTime.Parse(CheckIn);
                DateTime end = DateTime.Parse(CheckOut);
                TimeSpan difference = end - st;

                return total = (difference.Days * costPerNight);
            }

            
        }

       

        
    }
}
