using System;
//usando using Course.Entities.Enums para importar o tipo OrderStatus
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public DayOfWeekTime Today { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status
                + ", "
                + Today;
        }
    }
}
