using System;
using System.Collections.Generic;
using System.Text;
//using Abstraction.AbstrcatClass;
using Abstraction.InterFace;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AlatMusic alatmusic;

            alatmusic = new Guitar();
            alatmusic.Bunyi();

            Console.WriteLine();
            alatmusic = new Drumm();
            alatmusic.Bunyi();*/

            IAlatMusic alatmusic;
            alatmusic = new Guitar();
            alatmusic.Bunyi();

            Console.WriteLine();
            alatmusic = new Drumm();
            alatmusic.Bunyi();
            Console.ReadKey();
        }
    }
}
