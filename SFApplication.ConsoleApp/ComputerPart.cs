using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    abstract class ComputerPart
    {
        public abstract void Work();
        
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Processor");
        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("MotherBoard");
        }
    }

    class GraphicCard: ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("GraphicCard");
        }
    }
}
