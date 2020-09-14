using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Enums
{
    public enum OrderStatus
    {
        Init =1,
        Inprocess =2,
        WattingPayment= 3,
        Done = 4
    }
}
