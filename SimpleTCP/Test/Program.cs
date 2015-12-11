using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Test
{
    class Program
    {
        static void Main(string[] kwargs);
        {
            TestByteArray();


        }

        public ByteArray TestByteArray()
        {
            ByteArray byteArray = new ByteArray();

            Console.WriteLine(byteArray);
            return byteArray;

        }
        

    }   
}
    

