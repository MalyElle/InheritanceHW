using System;

namespace InheritanceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Berries SB = new Berries("StrawBerry", "Sweet", "Red", 1000);
            Berries BB = new Berries("BlackBerry", "Sweet and Sour", "Black", 500);

            SB.texture("super moist and mushy");
            BB.texture("very mushy");

            SB.amountBerries(2);
            BB.amountBerries(3);
        }
    }
}
