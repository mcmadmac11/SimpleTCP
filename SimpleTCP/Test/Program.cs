using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;

namespace SimpleTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Stanley";
            string weapon = "Water Balloons";
            int age = 19;
            PacketHeader.Warlord warlord = new PacketHeader.Warlord(name, weapon, age);

        

            Console.WriteLine(warlord);
            
            Console.ReadLine(); 


        }
    }   
}
    

