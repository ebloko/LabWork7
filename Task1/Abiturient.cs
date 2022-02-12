using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Abiturient
    {
        private string fullName;
        private int baseClass;
        private int avg;


        public int Value { get; set; }

        public static Abiturient operator +(Abiturient abiturient)  // 1 zad
        {
            abiturient.avg++;
            return abiturient;
        }

        public static Abiturient operator +(Abiturient abiturient1, Abiturient abiturient2) // 2 zad
        {
            Abiturient abiturient3 = new Abiturient();
            abiturient3.fullName = abiturient1.fullName;
            abiturient3.baseClass = abiturient1.baseClass;
            abiturient3.avg = abiturient1.avg + abiturient2.avg;
            return abiturient3;
        }

        public static bool operator ==(Abiturient abiturient1, Abiturient abiturient2) // task 3
        {
            return abiturient1.avg == abiturient2.avg && abiturient1.fullName == abiturient2.fullName && abiturient1.baseClass == abiturient2.baseClass;
        }

        public static bool operator !=(Abiturient abiturient1, Abiturient abiturient2)
        {
            return abiturient1.avg != abiturient2.avg || abiturient1.fullName != abiturient2.fullName || abiturient1.baseClass != abiturient2.baseClass;
        }

        public static bool operator true(Abiturient abiturient2) // task 4
        {
            return abiturient2.avg >= 0;
        }

        public static bool operator false(Abiturient abiturient2) 
        {   
            return abiturient2.avg < 0; 
        }



    }
}
