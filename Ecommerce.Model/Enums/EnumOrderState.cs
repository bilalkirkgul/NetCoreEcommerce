using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Enums
{
    public enum EnumOrderState
    {
        waiting = 0,//beklemde
        Unpaid = 1,//ödeme alınmadı
        Completed = 2//tamamalandı

    }
}
