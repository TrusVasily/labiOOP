using System;

namespace ConsoleApp3
{
    class Printer
    {
        virtual public void IAmPrinting(Television obj)
        {
            if (obj is News)
            {
                Console.WriteLine(obj.ToString()); ;
            }

            if (obj is Ad)
            {
                Console.WriteLine(obj.ToString());
            }

            if (obj is TVProgram)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}