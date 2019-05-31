using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceHW
{
    public class Fruit
    {
        public string _type { set; get; }
        public string _taste { set; get; }


        public Fruit(string type, string taste)
        {
            _type = type;
            _taste = taste;

            Console.WriteLine("Fruit have been born for human to eat!");
        }

        public void texture ( string textureTest)
        {
            Console.WriteLine("The forbidden {0} is no longer forbidden and its taste is {1}! The {0} is so {2}, that I never can imagine a taste like this! ", _type, _taste, textureTest);
        }
            
    }

    public class Berries : Fruit
    {
        public string _color { set; get; }
        public int _quantity { set; get; }

        public Berries(string type, string taste, string color, int quantity) : base (type,taste)
        {
            _type = type;
            _taste= taste;
            _color = color;
            _quantity = quantity;
        }

        public void amountBerries (int timesEaten)
        {
            for(int i = 0; i<timesEaten; i++)
            {
                Console.WriteLine("Humans you have took advantage of what I gave you and consume over {0} of my {1} {2}!",_quantity,_color,_type);
            }

        }
    }
}
