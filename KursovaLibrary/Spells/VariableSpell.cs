using System.Collections.Generic;

namespace KursovaLibrary
{
    public class VariableSpell : Spell
    {
        public double MaxDamage { get; set; }
        public override double BaseDamage { get; set; }
        public override string CalculateDamage(List<DamageModificator> _dm, Wizard wizard, Boss boss, double Enchant, double Critical)
        {
            _dm.Reverse();

            var _dm2 = new List<DamageModificator>(_dm);

            _dm2 = CheckPierce(wizard.Pierce, boss.Resist, _dm2);

            foreach (DamageModificator d in _dm2)
            {
                MaxDamage *= d.Damage;
                BaseDamage *= d.Damage;
            }

            MaxDamage *= CheckStats(wizard, boss);

            BaseDamage += wizard.FlatDamage;
            MaxDamage += wizard.FlatDamage;

            _dm.Reverse();

            return $"Your Damage will be between: {(int)BaseDamage} and {(int)MaxDamage}. And between {(int)(BaseDamage * Critical)} and {(int)(MaxDamage * Critical)} if it Crits.";
        }
    }
}
