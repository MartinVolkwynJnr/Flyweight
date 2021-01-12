using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.ConcreteFlyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class CharacterA : Character
    {
        // Constructor
        public CharacterA()
        {
            this.symbol = 'A';
            this.height = 100;
            this.width = 120;
            this.ascent = 70;
            this.descent = 0;
        }
    }
}
