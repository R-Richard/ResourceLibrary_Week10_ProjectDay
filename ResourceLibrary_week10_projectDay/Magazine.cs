using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceLibrary_week10_projectDay
{
    class Magazine : Resource
    {
        public override DateTime addDays()
        {
            int DaysDue = 2;
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(DaysDue);
            return answer;
        }
    }
}
