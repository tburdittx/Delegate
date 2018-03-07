using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static List<Apples> ListOfApples = new List<Apples>();
        static List<Apples> MoreApples = new List<Apples>();
        static List<Cart<Box<Apples>>> HowManyBoxes = new List<Cart<Box<Apples>>>();
        static void Main(string[] args)
        {
            Apples apples = new Apples();
            Cart<Apples> cart = new Cart<Apples>();
            Counter<Apples> counters = new Counter<Apples>();
            Counter<Apples> moreCounting = new Counter<Apples>();
            Counter<Apples> RedApples = new Counter<Apples>();
            Counter<Apples> MoreReds = new Counter<Apples>();

            ListOfApples.Add(new Apples() { colour = Colour.Green });
            ListOfApples.Add(new Apples() { colour = Colour.Green });
            ListOfApples.Add(new Apples() { colour = Colour.Red });
            ListOfApples.Add(new Apples() { colour = Colour.Red });
            ListOfApples.Add(new Apples() { colour = Colour.Red });
            ListOfApples.Add(new Apples() { colour = Colour.Red });
            ListOfApples.Add(new Apples() { colour = Colour.Red });
            ListOfApples.Add(new Apples() { colour = Colour.Red });
            ListOfApples.Add(new Apples() { colour = Colour.Red });

            foreach (Apples apple in ListOfApples)
            {
                // counters.RedCounter();
            }

            Box<Apples> box = new Box<Apples>();
            box.Add(ListOfApples);

            ListOfApples.ForEach(counters.Add);

            MoreApples.Add(new Apples() { colour = Colour.Green });
            MoreApples.Add(new Apples() { colour = Colour.Yellow });
            MoreApples.Add(new Apples() { colour = Colour.Yellow });
            MoreApples.Add(new Apples() { colour = Colour.Yellow });

            MoreApples.ForEach(moreCounting.Add);

            cart.Add(ListOfApples);
            cart.Add(MoreApples);
           
            Func<List<Apples>, int> Red = i => i.Where(a => a.colour == Colour.Red).Count();
            RedApples.Add(ListOfApples, Red);            

            Console.WriteLine($"Number of Red Apples in First Box: {RedApples.Count()}");            

            Console.WriteLine("Number of Apples in Box 1: {0}", counters.Count());
            Console.WriteLine($"Number of Apples in Box 2: {moreCounting.Count()}");
            Console.WriteLine($"Number of Apples in the cart: {cart.Count()} ");

            Console.ReadLine();
        }
    }
}