using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstrcatClass
{
    class Drumm : AlatMusic
    {
        public override void Bunyi()
        {
            Console.WriteLine("Drum berbunyi dengan cara dipukul");
            Console.WriteLine("Alat music drumm dipukul menggunakan stik");
        }
    }
}
