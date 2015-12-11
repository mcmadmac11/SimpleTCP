using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;




namespace SimpleTCP
{
    class SerializeObject
    {
        static void Main(string[] args)
        {
            Person pers = new Person();
            pers.age = 33;
            pers.name = "Dan";  
        
        Stream stream = File.Open("ObjectInfo.txt", FileMode.Open);
        BinaryFormatter binFormatter = new BinaryFormatter();

        Console.WriteLine("Writing Person Info");
            binFormatter.Serialize(stream, pers);
            stream.Close();

        pers = null;
            stream = File.Open("objectInfo.txt", FileMode.Open);
            binFormatter = new BinaryFormatter();

            Console.WriteLine("reading person information");
            pers = (Person)binFormatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("Persons Age: {0}", pers.age.ToString());
            Console.WriteLine("Persons Name: {0}", pers.name.ToString());

        }    
        


        


    }
}
