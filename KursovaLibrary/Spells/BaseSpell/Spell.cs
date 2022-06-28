using System;
using System.Collections.Generic;
using System.Linq;

namespace KursovaLibrary
{
    public abstract class Spell
    {
        public virtual double BaseDamage { get; set; }

        public abstract string CalculateDamage(List<DamageModificator> _dm, Wizard wizard, Boss boss,double Enchant, double Critical);

        public List<DamageModificator> CheckPierce(double pierce,double resist, List<DamageModificator> _dm)
        {
            if (pierce > 0)
            {
                if (_dm.Any(s => s is Shield))
                {
                    double maxshield = Math.Round(_dm
                                    .Where(s => s is Shield)
                                    .Min(s => s.Damage), 2);

                    var shieldtoremove = _dm
                        .Where(s => s is Shield)
                        .Single(s => s.Damage == maxshield);

                    _dm.Remove(shieldtoremove);

                    // Recursion :(
                    if (pierce - (100 - (maxshield * 100)) > 0)
                    {
                        return CheckPierce(pierce - (100 - maxshield * 100), resist, _dm);
                    }
                    else
                    {
                        _dm.Add(new Shield { Damage = Math.Round(Math.Abs(pierce - (100 - maxshield * 100))) });
                        return _dm;
                    }
                }
                else if(resist > 0)
                {
                    if (pierce - resist > 0)
                    {
                        return _dm;
                    }
                    else
                    {
                        _dm.Add(new Shield { Damage = Math.Abs(pierce - resist) });
                        return _dm;
                    }
                }
                else
                    return _dm;
                
            }
            else
                return _dm;
        }

        protected double CheckStats(Wizard wizard, Boss boss)
        {
            double increase = 1;

            if (wizard.PercentDamage != 0)
            {
                increase = 1 + wizard.PercentDamage / 100;
            }
            if (boss.Boost != 0)
            {
                increase = 1 + boss.Boost / 100;
            }
            return increase;
        }


    }
}
