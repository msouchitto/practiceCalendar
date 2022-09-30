using System;
using System.Collections.Generic;
using System.Text;

namespace practiceCalendar
{
    class Transaction
    {
        private string description { get; set; }
        private double price { get; set; }
        private DateTime date = new DateTime();

        public void setDate(int month, int day, int year, int hours, int minutes, int seconds)
        {
            date = date.AddDays(day).AddMonths(month).AddYears(year).AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);
        }
        public DateTime getDate()
        {
            return date;
        }

        public void setDescription(string d)
        {
            description = d;
        }
        
        public string getDescription()
        {
            return description;
        }

        public void setPrice(double p)
        {
            price = p;
        }

        public double getPrice()
        {
            return price;
        }

      

        

    }
}
