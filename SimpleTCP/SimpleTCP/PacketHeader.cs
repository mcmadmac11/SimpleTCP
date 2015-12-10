using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.IO;


namespace SimpleTCP
{
    public abstract class ByteArray
    {
        public static ByteArray CreateByteArray(int sourcePort, int destinationPort, int sequenceNumber, int acknowledgementNumber)
        {
            return new ByteArray(sourcePort, destinationPort, sequenceNumber, acknowledgementNumber);
        }

        public BitArray SourcePort { get; private set; } 

        public BitArray _destinationPort { get; private set; } // 16
        public BitArray _sequenceNumber { get; private set; } // 32
        public BitArray _acknowledgementNumber { get; private set; } // 32
        public BitArray _dataOffset { get; private set; } // 4
        public BitArray _reserved { get; private set; } // 3
        public BitArray _flags { get; private set; } // 9
        public BitArray _windowSize { get; private set; } //16
        public BitArray _checkSum { get; private set; } // 16
        public BitArray _urgentPointer { get; private set; } //
        public BitArray _options { get; private set; } // (between 0/10)


        private ByteArray(int sourcePort, int destinationPort, int sequenceNumber, int acknowledgementNumber)
        {
            
        }
        
    }    





    public class Warlord
    {


            public Warlord(string name, string weapon, int age)
            {


                name = "Stanley";
                age = 19;
                weapon = "water balloons";
            }




    }

}


    

   








