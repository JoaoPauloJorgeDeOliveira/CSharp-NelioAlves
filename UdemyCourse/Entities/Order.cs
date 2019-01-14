using System;
using UdemyCourse.Entities.Enums;

namespace UdemyCourse.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + ", Moment: " + Moment + ", Status: " + Status;
        }
    }
}
