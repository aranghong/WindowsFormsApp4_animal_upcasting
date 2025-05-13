using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4_animal_upcasting
{
    public class animal
    {
        public string name;

        public void speak()
        {
            Console.WriteLine($"{name} 동물이 소리를 냅니다.");
        }

    }

    public class dog : animal
    {
        public string Name { get; set; }

        public string d()
        {
            return "멍멍";
        }

    }

    public class cat : animal
    {
        public string Name { get; set; }
        public string c()
        {
            return "야옹";
        }
    }

    public class bird : animal
    {
        public string Name { get; set; }
        public string b()
        {
            return "짹짹";
        }

    }
}
