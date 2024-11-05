using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered,
                Today = DayOfWeekTime.Tuesday
            };

            Console.WriteLine(order);
        }
    }

}
