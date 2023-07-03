using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment=0,
        Processing = 1,
        shipped =2,
        Delivered = 3
    }
}
