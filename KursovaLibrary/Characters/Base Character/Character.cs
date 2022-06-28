using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaLibrary.Characters.Base_Character
{
    [Serializable]
    public abstract class Character
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public Character(string name, int id)
        {
            Name = name;
            ID = id;
        }


    }
}
