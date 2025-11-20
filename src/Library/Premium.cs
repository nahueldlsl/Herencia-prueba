using System;

namespace Ucu.Poo.Ocp
{
    public class Premium : Membresia
    {
        public override bool PuedeIngresar(DateTime date, int hour)
        {

            if (Calendar.IsHoliday(date))
            {

                if (hour >= 10)
                {
                    if (hour < 18)
                    {
                        return true;
                    }
                }
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

            if (hour >= 6)
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