using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.FlyweightFactory
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class CharacterFactory
    {
        Dictionary<char, Character> characters = new Dictionary<char, Character>();

        // Character indexer
        public Character this[char key]
        {
            get
            {
                // Uses "lazy initialization" -- i.e. only create when needed.
                Character character = null;
                if (characters.ContainsKey(key))
                {
                    character = characters[key];
                }
                else
                {
                    // Instead of a case statement with 26 cases (characters).
                    // First, get qualified class name, then dynamically create instance 
                    string name = this.GetType().Namespace + "." + "Character" + key.ToString();
                    character = (Character)Activator.CreateInstance(Type.GetType(name));
                }

                return character;
            }
        }
    }
}
