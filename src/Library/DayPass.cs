using System;

namespace Ucu.Poo.Ocp
{
    public class DayPass : Membresia
    {
        public override bool PuedeIngresar(DateTime date, int hour)
        {
            if (Calendar.IsHoliday(date))
            {
                return false;
            }

            DayOfWeek dia = date.DayOfWeek;
            if (dia == DayOfWeek.Saturday)
            {
                return false;
            }

            if (dia == DayOfWeek.Sunday)
            {
                return false;
            }
            if (hour >= 10)
            {
                if (hour < 17)
                {
                    return true;
                }
            }

            return false;
        }
    }
}