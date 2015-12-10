using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SimpleTCP
{


    class TCPPacket<T>
    {
        public object var { get; private set; }

        public byte[] ObjectToByteArray(T data) {
            try {
                BinaryFormatter formatter = new BinaryFormatter();
                using (MemoryStream memoryStream= new MemoryStream();
                {
                    formatter.Serialize(memoryStream)
               
        {
            if(var == null)
            return null;
            BinaryFormatter binFormat = new BinaryFormatter();
            MemoryStream memStrm = new MemoryStream();
            binFormat.Serialize(memStrm, var); 
            return memStrm.ToArray();             
        }

        public object ByteArrayToObject(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryForm = new BinaryFormatter();
            memoryStream.Write(bytes, 0, bytes.Length);
            memoryStream.Seek(0, SeekOrigin.Begin);
            Object var = (Object)binaryForm.Deserialize(memoryStream);
            return var;
        }

      
    }
}
