using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLibrary
{
    public class Blade : DamageModificator
    {
        private double blade;

        public override double Damage
        {
            get
            {
                return Math.Round(1 + blade / 100, 2);
            }
            set
            {
                blade = value;
            }
        }

        public override string ToString()
        {
            return $"+{blade}% Blade";
        }

    }
}
