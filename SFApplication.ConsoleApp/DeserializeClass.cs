using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using System.Reflection;

namespace SFApplication.ConsoleApp
{
    static class DeserializeClass
    {
        static public T[] DeserializeMeth<T>(string path)
        {   
            T[] students = null;
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Binder = new CustomBinder();
                try
                {
                    using (var fs = new FileStream(path, FileMode.Open))
                    {
                        students = (T[])formatter.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
                
                
            }
            return students;
        }
    }

    public class CustomBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Assembly currentasm = Assembly.GetExecutingAssembly();

            return Type.GetType($"{currentasm.GetName().Name}.{typeName.Split('.')[1]}");
        }
    }
}
