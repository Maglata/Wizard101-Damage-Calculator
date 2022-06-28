using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLibrary
{
    public class Shield : DamageModificator
    {
        private double shield;
        public override double Damage
        {
            get
            {
                return Math.Round(1 - shield / 100,2);
            }
            set
            {
                shield = value;
            }
        }
        public override string ToString()
        {
            return $"-{shield}% Shield";
        }
    }
}
