using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstrcatClass
{
    class Guitar : AlatMusic
    {
        public override void Bunyi()
        {
            Console.WriteLine("Alat music gitar akan berbunyi dengan cara dipetik");
            Console.WriteLine("Kadang gitar juga memerlukan sound agar bisa didengarkan dengan sangat jelas yaitu gitar elektrik");
        }
    }
}
