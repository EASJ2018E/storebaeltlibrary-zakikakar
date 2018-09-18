using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using BilletLibrary;

namespace StoreBaeltLibrary
{
    public class WeekendRabat
    {
        Bil bil = new Bil();

        DayOfWeek dag = DateTime.Now.DayOfWeek;

        //public decimal weekendPrisMBroBizz;

        public decimal WeekendPris()
        {
            if (dag == DayOfWeek.Saturday || dag == DayOfWeek.Sunday && bil.AnvendtBrobizz)
            {
                return bil.Pris() * (decimal) 0.80 * (decimal) 0.95;
            }

            return bil.Pris() * (decimal) 0.80;
        }
    }


}
