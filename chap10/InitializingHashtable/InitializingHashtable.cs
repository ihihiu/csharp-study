using System;
using static System.Console;
using System.Collections;

namespace InitializingHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                ["하나"] = 1,
                ["둘"] = 2,
                ["셋"] = 3
            };
            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);

            Hashtable ht2 = new Hashtable()
            {
                {"하나",1 },
                {"둘",2 },
                {"셋",3 }
            };

            WriteLine(ht2["하나"]);
            WriteLine(ht2["둘"]);
            WriteLine(ht2["셋"]);
        }
    }
}