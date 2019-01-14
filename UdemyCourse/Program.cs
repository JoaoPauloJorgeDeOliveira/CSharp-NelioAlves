using System;
using UdemyCourse.Entities;
using UdemyCourse.Entities.Enums;

namespace UdemyCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment};

            Console.WriteLine(o);

        }
    }
}
