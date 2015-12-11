using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleTCP
{
    [Serializable]
    public class Person : ISerializable
    {
        public int age;
        public string name;

        public Person()
        {
            age = 33;
            name = null;
        }
    // serialization function
        public Person(SerializationInfo info, StreamingContext context);
        

            

        
        }    

    }
}
