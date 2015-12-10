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
        public byte[] ObjectToByteArray(Object obj)
        {
            if(obj == null)
            return null;
            BinaryFormatter binFormat = new BinaryFormatter();
            MemoryStream memStrm = new MemoryStream();
            binFormat.Serialize(memStrm, obj); 
            return memStrm.ToArray();             
        }

        public object ByteToArray(byte[] arrBytes)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryForm = new BinaryFormatter();
            memoryStream.Write(arrBytes, 0, arrBytes.Length);
            memoryStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object) binaryForm.Deserialize(memoryStream);
            return obj;
        }
    }
}
