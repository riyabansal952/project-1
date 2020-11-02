
using System;
namespace ConstructorExample
{

    class Riya
    {

        int id;
        string name;
        Riya()
        {
            Console.WriteLine("Default Constructor Called");
        }
        Riya(String name, int id)
        {
            this.name = name;
            this.id = id;
        }

     
        public static void Main()
        { 
            Riya r1 = new Riya(); 
            Riya r2 = new Riya("Riya Bansal", 1);
            Console.WriteLine("RiyaName = " + r2.name + " and RiyaId = " + r2.id);
          
        }
    }
}