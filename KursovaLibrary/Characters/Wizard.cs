using KursovaLibrary.Characters.Base_Character;
using System;

namespace KursovaLibrary
{
    [Serializable]
    public class Wizard : Character
    {
        public double FlatDamage { get; set; }

        public double PercentDamage { get; set; }

        public double Pierce { get; set; }

        public Wizard(string name, int id, double flatdamage, double percentdamage, double pierce) : base(name, id)
        {
            FlatDamage = flatdamage;
            PercentDamage = percentdamage;
            Pierce = pierce;
        }

    }
}
