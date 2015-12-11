using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace SimpleTCP
{
    class TCPBody
    {

        public BitArray bitArray2()
        {
            BitArray bitArray2 = new BitArray(5);
            bitArray2.Set(0, true);

            bitArray2.Set(3, true);
            if (bitArray2 == (null))
                return null;
            else
            {
                foreach (bool bit in bitArray2) ;
                Console.WriteLine(bitArray2);


                return bitArray2;
            }

             
                
            

        



        }

    }
}
