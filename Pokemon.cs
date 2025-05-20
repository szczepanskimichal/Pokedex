
namespace Pokedex
{
    internal class Pokemon
    {
        

        public int Health;
        public int Level;
        public string Name;

        public Pokemon(string name)
        {
            Name = name;
        }

        public Pokemon(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public Pokemon()
        { 
        
        }
    }
}
