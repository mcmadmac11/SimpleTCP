using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCP.Tests
{
    [TestClass()]
    public class TCPPacketTests<T>
    {

        public object ID
        {
            get { return this.ID; }
            set { this.ID = value; } 
                
                    
                
        }






        [TestMethod()]
        public void ObjectToByteArrayTest(int ID)
        {

            this.ObjectToByteArrayTest(123);
            Console.WriteLine(ID);
            // Assert.Fail();
        }
        
        

             
         
           
        
    }
}