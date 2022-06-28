using System.Collections.Generic;

namespace KursovaLibrary
{
    public class DoTSpell : Spell
    {
        public double DoT { get; set; }

        public override double BaseDamage { get; set; }

        public override string CalculateDamage(List<DamageModificator> _dm, Wizard wizard, Boss boss, double Enchant, double Critical)
        {
            _dm.Reverse();

            var _dm2 = new List<DamageModificator>(_dm);

            _dm2 = CheckPierce(wizard.Pierce, boss.Resist, _dm2);

            foreach (DamageModificator d in _dm2)
            {
                BaseDamage *= d.Damage;
                DoT *= d.Damage;
            }

            BaseDamage *= CheckStats(wizard, boss);
            DoT *= CheckStats(wizard, boss);

            BaseDamage += wizard.FlatDamage;
            DoT += wizard.FlatDamage;

            _dm.Reverse();

            return $"Your Damage will be: {(int)BaseDamage} + {(int)DoT} overtime. And {(int)BaseDamage*Critical} + {(int)DoT*Critical} overtime if it Crits.";
        }
    }
}
