using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_animal_upcasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dog d = new dog();
            cat c = new cat();
            bird b = new bird();

            //업캐스팅
            animal a1 = d;
            animal a2 = c;
            animal a3 = b;

            a1.name = "강아지";
            a1.speak(); //->부모 메서드 가능
            //a1.d();   //->자식 메서드 에러

            a2.name = "고양이";
            a2.speak(); //->부모 메서드 가능
            //a2.c();   //->자식 메서드 에러

            a3.name = "새";
            a3.speak(); //->부모 메서드 가능
            //a3.b();   //->자식 메서드 에러


            //다운캐스팅
            Console.WriteLine($"다운캐스팅: {((dog)a1).d()}");
            Console.WriteLine($"다운캐스팅: {((cat)a2).c()}");
            Console.WriteLine($"다운캐스팅: {((bird)a3).b()}");

        }
    }
}
