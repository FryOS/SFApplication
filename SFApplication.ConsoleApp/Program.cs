using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Объект завода, который будет заниматься производством
            var carPlant = new CarPlant();

            Conveyor builder = new CarConveyor();
            builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            Console.ReadKey();
        }


    }

    class Product
    {
        private string _type;

        // составные части
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        /// <summary>
        ///  Метод - конструктор
        /// </summary>
        public Product(string type)
        {
            _type = type;
        }
        // Индексатор
        public string this[string key]
        {
            set
            {
                _parts[key] = value;
            }
        }
        /// <summary>
        /// Метод для получения информации о продукте
        /// </summary>
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид транспортного средства: {_type}");
            Console.WriteLine($" Рама : {_parts["frame"]}");
            Console.WriteLine($" Двигатель : {_parts["engine"]}");
            Console.WriteLine($" Колеса: {_parts["wheels"]}");
            Console.WriteLine($" Двери : {_parts["doors"]}");
        }
    }

    /// <summary>
    /// Абстрактный класс строителя
    /// </summary>
    abstract class Conveyor
    {
        protected Product _product;

        public Product Product
        {
            get { return _product; }
        }
        // Методы для постройки составных частей

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }

    /// <summary>
    /// Автомобильный завод
    /// </summary>
    class CarPlant
    {
        /// <summary>
        /// Запуск процесса постройки
        /// </summary>
        public void Construct(Conveyor conveyor)
        {
            conveyor.BuildFrame();
            conveyor.BuildEngine();
            conveyor.BuildWheels();
            conveyor.BuildDoors();
        }
    }

    class CarConveyor : Conveyor
    {
        public CarConveyor()
        {
            _product = new Product("Автомобиль");
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама автомобиля";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "150 л.с.";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _product["doors"] = "4";
        }
    }

}

