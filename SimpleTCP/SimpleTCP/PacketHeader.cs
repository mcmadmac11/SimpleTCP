using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;


namespace SimpleTCP
{
    public class PacketHeader<T>    
    {
        public BitArray _sourcePort { get; private set; } // 16
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
    

   
 
    
         

        
        
        
       
    }
}   








