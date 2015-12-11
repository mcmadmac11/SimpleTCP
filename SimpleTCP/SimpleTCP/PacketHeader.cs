using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.IO;
using System.Windows.Markup;


namespace SimpleTCP
{
    public class ByteBit
    {
        public BitArray _dataOffset1;


        public BitArray _sourcePort
        {
            get { return this._sourcePort; }
            private set { this._sourcePort = value; }
        }

        public BitArray _destinationPort   //16
        {
            get { return this._destinationPort; }
            private set { this._destinationPort = value; }
        }

        public BitArray _sequenceNumber
        {
            get { return this._sequenceNumber; }
            private set { this._sequenceNumber = value; }
        } // 32

        public BitArray _acknowledgementNumber // 32
        {
            get { return this._acknowledgementNumber; }
            private set { this._acknowledgementNumber = value; }
        }

        private void set_dataOffset(BitArray value)
        {
            _dataOffset1 = value;
        }

        public BitArray get_dataOffset()
        {
            return _dataOffset1;
        }

// 4
        public BitArray _reserved { get; private set; } // 3
        public BitArray _flags { get; private set; } // 9
        public BitArray _windowSize { get; private set; } //16
        public BitArray _checkSum { get; private set; } // 16
        public BitArray _urgentPointer { get; private set; } //
        public BitArray _options { get; private set; } // (between 0/10)


        public BitArray HeaderConfig()
        {
            _sourcePort[0] = false;
            _sourcePort[1] = true;
            _sourcePort[2] = true;
            _sourcePort[3] = false;
            return _sourcePort;


      



        
    }    

} }


    

   








