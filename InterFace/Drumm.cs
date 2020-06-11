using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.InterFace
{
    class Drumm : IAlatMusic
    {
        public void Bunyi()
        {
            Console.WriteLine("Drum berbunyi dengan cara dipukul");
            Console.WriteLine("Alat music drumm dipukul menggunakan stik");
        }
    }
}
