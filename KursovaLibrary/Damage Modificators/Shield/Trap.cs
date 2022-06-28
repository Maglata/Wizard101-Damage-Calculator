using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLibrary
{
    public class Trap : DamageModificator
    {
        private double trap;
        public override double Damage
        {
            get
            {
                return Math.Round(1 + trap / 100, 2);
            }
            set
            {
                trap = value;
            }
        }
        public override string ToString()
        {
            return $"+{trap}% Trap";
        }
    }
}
