using System;
using System.Collections.Generic;
using System.Linq;



namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var softwareManufacturers = new List<string>()
            {
               "Microsoft", "Apple", "Oracle"
            };

            var hardwareManufacturers = new List<string>()
            {
               "Apple", "Samsung", "Intel"
            };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

            Console.WriteLine(CountCommon("one", "twoe"));

            //foreach (var v in itCompanies)
            //  Console.WriteLine(v);


            //PunctExept();

            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            var wrongContacts = (from s in contacts 
                                 let phone = s.Phone.ToString()
                                 where !phone.StartsWith("7") || phone.Length != 11
                                 select s
                                 ).Count();

            //Console.WriteLine(wrongContacts);

            var phoneBook = new List<Contact1>();

            // добавляем контакты
            phoneBook.Add(new Contact1("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact1("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact1("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact1("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact1("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact1("Иннокентий", 799900000013, "innokentii@example.com"));

            var fakeEmails = phoneBook.GroupBy(c => c.Email.Split('@').Last());

            //foreach (var items in fakeEmails)
            //{
            //    if (items.Key.Contains("example"))
            //    {
            //        Console.WriteLine("Fake \n");
            //        foreach (var item in items)
            //            Console.WriteLine(item.Email + " " + item.Name);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Fake \n");
            //        foreach (var item in items)
            //            Console.WriteLine(item.Email + " " + item.Name);
            //    }

            //}

            var departments = new List<Department>()
            {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"}
            };
            
            var employees = new List<Employee>()
            {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };


            var result = departments.Join(employees,
                dep => dep.Id,
                em => em.DepartmentId,
                (dep, em) => new
                {
                    ID = dep.Id,
                    DepName = dep.Name,
                    EmpName = em.Name
                });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.DepName} {item.EmpName}");
            //}

            var result1 = departments.GroupJoin(employees,
                dep => dep.Id,
                em => em.DepartmentId,
                (dep, em) => new
                {
                    DepName = dep.Name,
                    EmpName = em.Select(e => e.Name)

                });

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item.DepName + ":");

            //    // Выводим сотрудников
            //    foreach (string emp in item.EmpName)
            //        Console.WriteLine(emp);

            //    Console.WriteLine();
            //}

            var customers = new Customer[]
               {
                   new Customer{ID = 5, Name = "Андрей"},
                   new Customer{ID = 6, Name = "Сергей"},
                   new Customer{ID = 7, Name = "Юлия"},
                   new Customer{ID = 8, Name = "Анна"}
               };

            var orders = new Order[]
            {
                   new Order{ID = 6, Product = "Игру"},
                   new Order{ID = 7, Product = "Компьютер"},
                   new Order{ID = 3, Product = "Рубашку"} ,
                   new Order{ID = 5, Product = "Книгу"}
            };

            var query = from c in customers
                        join o in orders on c.ID equals o.ID
                        select new { c.Name, o.Product };
            //foreach (var group in query)
            //    Console.WriteLine($"{group.Name} покупает {group.Product}");


            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            foreach (var item in classes)
            {
                var clc = item.Students.ToArray();
                var arrs = clc.Select(s => s);
            }



            Console.ReadLine();
        }


        static void PrintArr()
        {
            var arr = new List<int>();

            while (true)
            {
                string str = Console.ReadLine();
                arr.Add(Convert.ToInt32(str));
                var countvar =  arr.Count();
                var maxvar =  arr.Max(s => s);
                var minvar =  arr.Min(s => s);
                var avrvar =  arr.Average(s => s);
            }
        }


        static double Average(int[] numbers)
        {
            var sumNumbers = (numbers.Sum(s => s)) / (double)numbers.Length;
            return sumNumbers;
        }

        static int CountCommon(string word1, string word2)
        {
            var amount = word1.Intersect(word2)//   ищем пересечение
            .Count(); // считаем количество
            return amount;
        }

        static void PunctExept()
        {
            Console.WriteLine("Введите текст:");

            // читаем ввод
            var text = Console.ReadLine();

            // сохраняем список знаков препинания и символ пробела в коллекцию
            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

            // валидация ввода
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ввели пустой текст");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Текст без знаков препинания: ");

            // так как строка - это массив char, мы можем вызвать метод  except  и удалить знаки препинания
            var noPunctuation = text.Except(punctuation).ToArray();

            // вывод
            Console.WriteLine(noPunctuation);
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
    }

    public class Contact1
    {
        public Contact1(string name, long phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;

        }

        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int ID { get; set; }
        public string Product { get; set; }
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }

    //static string[] GetAllStudents(Classroom[] classes)
    //{
        
    //}
}
