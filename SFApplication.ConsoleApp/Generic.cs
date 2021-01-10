using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }
    abstract class CarPart { }
    abstract class Engine { }

    class ElectricEngine : Engine
    {
       
    }

    class GasEngine : Engine
    {
        
    }

    class Battery: CarPart { }

    class Differential: CarPart { }

    class Wheel: CarPart { }

    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
}
