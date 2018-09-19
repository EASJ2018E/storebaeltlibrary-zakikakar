using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using BilletLibrary;

namespace StoreBaeltLibrary
{
    public class StoreBaeltBil : Bil
    {
        public DayOfWeek dag; /*DateTime.Now.DayOfWeek;*/
        

        public decimal WeekendPris()
        {
            if (dag == DayOfWeek.Saturday || dag == DayOfWeek.Sunday && AnvendtBrobizz)
            {
                return Pris() * (decimal) 0.80 * (decimal) 0.95;
            }
            else if (dag == DayOfWeek.Saturday || dag == DayOfWeek.Sunday && !AnvendtBrobizz)
            {
                return Pris() * (decimal) 0.80;
            }
            else if (dag == DayOfWeek.Saturday || dag == DayOfWeek.Sunday && AnvendtBrobizz)
            {
                return Pris() * (decimal) 0.95;
            }

            return Pris();

        }
    }
}
