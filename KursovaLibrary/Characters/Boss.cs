using KursovaLibrary.Characters.Base_Character;
using System;

namespace KursovaLibrary
{
    [Serializable]
    public class Boss : Character
    { 
        public double Resist { get; set; }

        public double Boost { get; set; }

        public Boss(string name, int id, double resist, double boost) : base(name, id)
        {
            Resist = resist;
            Boost = boost;
        }

    }
}
