using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Counter<t>
    {
        Apples apple = new Apples();
        int count;
       
        public void Add(t item)
        {
            count++;
        }
        public int Count()
        {
            return count;
        }

        public void Add(List<Apples> items)
        {
            count = items.Count();
        }

        public void Add(List<Apples> items, Func<List<Apples>, int> Red )
        {
            count = Red(items);
        }            
    }
}
