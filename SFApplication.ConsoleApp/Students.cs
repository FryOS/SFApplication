using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFApplication.ConsoleApp
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private List<string> languages;

        public List<string> Languages
        {
            get { return languages; }
            set { languages = value; }
        }
    }
}
