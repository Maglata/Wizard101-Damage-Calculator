using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLibrary
{
    public class Weakness : DamageModificator
    {
        private double weakness;
        public override double Damage 
        { 
            get 
            {
                return Math.Round(1 - weakness / 100, 2);
            } 
            set 
            {
                weakness = value;
            }
        }
        public override string ToString()
        {
            return $"-{weakness}% Weakness";
        }
    }
}
