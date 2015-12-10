using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleTCP
{
    public class TCPPacket<T>
    {
        public byte[] ObjectToByteArray(T data)
        {
            try
            {
                var formatBinary = new BinaryFormatter();
                using (var memoryStream = new MemoryStream())
                {
                    formatBinary.Serialize(memoryStream, data);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception)
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
    }
}