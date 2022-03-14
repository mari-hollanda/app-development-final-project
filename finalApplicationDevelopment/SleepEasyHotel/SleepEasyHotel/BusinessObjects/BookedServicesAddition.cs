using System;

/* 
 * Booked Services Addition Class
 * @since 20220220
 * Created to set the cost of a booking per night.
 */
namespace SleepEasyHotel.BusinessObjects
{
    class BookedServicesAddition
    {
        //Creating variables
        private static string CheckIn, CheckOut;
        private double costPerNight = 80.00;
        private double total;
       
        //Calculate Total Method
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
