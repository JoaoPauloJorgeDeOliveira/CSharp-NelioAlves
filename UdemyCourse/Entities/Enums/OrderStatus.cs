using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse.Entities.Enums
{
    enum OrderStatus : int //Dois pontos indica derivação. OrderStatus é um derivado do tipo base int.
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
