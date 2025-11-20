using System;

namespace Ucu.Poo.Ocp
{
    /// <summary>
    /// Esta clase representa un gimnasio con reglas de acceso basadas en el
    /// tipo de usuario, día de la semana y hora del día.
    /// </summary>
    public class Gym
    {
        /// <summary>
        /// Determina si un usuario puede ingresar al gimnasio en un día y hora.
        /// </summary>
        /// <param name="membership"></param>
        /// <param name="date"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            Membresia persona;

            if (membership == Membership.Basic)
            {
                persona = new Basic();
            }
            else if (membership == Membership.Premium)
            {
                persona = new Premium();
            }
            else
            {
                persona = new DayPass();
            }
            return persona.PuedeIngresar(date, hour);
        }
    }
}
