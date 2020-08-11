using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EHoliday
    {
        public DataTable dtHoliday { get; set; }
        public object HoliDayID { get; set; }
        public object HoliDayDate { get; set; }
        public object HoliDayName { get; set; }
        public object CategoryID { get; set; }
        public object UserID { get; set; }
        public DataTable dtHolidayType { get; set; }
    }
}
