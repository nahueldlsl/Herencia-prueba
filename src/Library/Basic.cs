using System;

namespace Ucu.Poo.Ocp
{
    public class Basic : Membresia
    {
        public override bool PuedeIngresar(DateTime date, int hour)
        {
            if (Calendar.IsHoliday(date))
            {
                return false;
            }

            DayOfWeek dia = date.DayOfWeek;

            if (dia == DayOfWeek.Sunday)
            {
                return false;
            }

            if (dia == DayOfWeek.Saturday)
            {
                if (hour >= 8)
                {
                    if (hour < 20)
                    {
                        return true;
                    }
                }
                return false;
            }

            if (hour >= 10)
            {
                if (hour < 21)
                {
                    return true;
                }
            }

            return false;
        }
    }
}