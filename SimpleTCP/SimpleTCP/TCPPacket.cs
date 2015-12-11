using System;
using System.CodeDom;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace SimpleTCP
{
//http://www.winsocketdotnetworkprogramming.com/clientserversocketnetworkcommunication8f.html
    [Serializable]
    public class TCPPacket<T>
    {
        public byte[] bytes { get; set; }                  
        public byte[] ObjectToByteArray(T data)
        {
            try
            {
                BinaryFormatter formatBinary = new BinaryFormatter();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    formatBinary.Serialize(memoryStream, data);
                    return memoryStream.ToArray();
                }
            }
                catch (Exception e)
            {
                return new byte[64];
            }
            
        }   



        public object ByteArrayToObject(byte[] bytes)
        {
            var binFormatter = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                memoryStream.Write(bytes, 0, bytes.Length);
                memoryStream.Seek(0, SeekOrigin.Begin);
                var newObject = binFormatter.Deserialize(memoryStream);
                return newObject;
            }
        }

        public TCPPacket(T data)
        {
            bytes = ObjectToByteArray(data);



        } 
    }

}   