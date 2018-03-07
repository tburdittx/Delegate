using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Apples : ICountable
    {
        public Colour colour;
        private int apple=1;

        public int Count()
        {
            return apple;
        }
    }
    public enum Colour
    {
        Red,
        Green,
        Yellow,
    }
}
