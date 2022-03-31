using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarealibro
{
    internal class EmpleadoPorHoras : Empleado
    {
        private decimal sueldo;
        private decimal horas;
        public EmpleadoPorHoras(string nombre, string apellido, string nss,decimal sueldoPorhoras,decimal horasTrabajadas) 
            : base(nombre, apellido, nss)
        {
            Sueldo = sueldoPorhoras;
            Horas = horasTrabajadas;
        }
        public decimal Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = (value >= 0) ? value : 0;
            }
        }
        public decimal Horas
        {
            get
            {
                return horas;
            }
            set
            {
                horas = ((value >= 0) && (value <= 168)) ? value : 0;
            }
        }
        public override decimal Ingresos()
        {
            if (Horas <= 40)
            {
                return sueldo * Horas;
            }
            else
            {
                return (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M);
            }
        }
        public override string ToString()
        {
            return String.Format("Empleado por horas :{0}\n{1}: {2:C}; {3}:{4:F2}",
                base.ToString(),"Sueldo por horas",Sueldo, "Horas trabajadas",Horas);
        }
    }
}
