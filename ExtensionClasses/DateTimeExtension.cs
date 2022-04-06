using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.ExtensionClasses
{
    public static class DateTimeExtension
    {
        public static int NumberDaysBeforeDelivery(this DateTime date)
        {
            if (date > DateTime.Now)
                return date.Day - DateTime.Now.Day;
            else
                return 0;
        }
    }
}
