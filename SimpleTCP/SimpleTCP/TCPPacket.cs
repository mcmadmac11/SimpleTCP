using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleTCP
{
    internal class TCPPacket
    {
        public byte[] ObjectToByteArray(object theDude)
        {
            throw new NotImplementedException();
         
            
                var formatter = new BinaryFormatter();
                using (var memoryStream = new MemoryStream())
                {
                    formatter.Serialize(memoryStream, theDude);
                }

                if (theDude == null)
                {


                    return null;
                    var binFormat = new BinaryFormatter();
                    var memStrm = new MemoryStream();
                    binFormat.Serialize(memStrm, theDude);
                    return memStrm.ToArray();
                }
            }
                












            object ByteArrayToObject 
                (byte[]
                bytes)
                {
                    var memoryStream = new MemoryStream();
                    var binaryForm = new BinaryFormatter();
                    memoryStream.Write(bytes, 0, bytes.Length);
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    var var = binaryForm.Deserialize(memoryStream);
                    return var;
                }
            }
        }