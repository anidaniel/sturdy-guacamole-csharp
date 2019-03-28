using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_project
{
    //struct Anidaniel
    //{
    //    string name, addr;
    //    int num;
    //};

    class Struct
    {
        struct Anidaniel
        {
            public string name, addr;       // keyword "public" is essential or it won't take the reference from the struct as it'll be protected
            public int num;
        };

        static void Main(string[] args)
        {

            Anidaniel rabi;
            rabi.name = "Rabiyudeen Jalaludeen";
            rabi.addr = "Habibi from DUBAI";
            rabi.num = 987654123;
            Console.WriteLine("NAME: {0}\nADDRESS: {1}\nNUMBER: {2}\n ",rabi.name,rabi.addr,rabi.num);
            //Console.WriteLine("WTF");
            Console.ReadLine();
        }
    }
}
