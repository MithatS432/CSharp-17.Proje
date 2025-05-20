using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_ve_Nesne_Yönelimli_Programlama__OOP_1
{
    internal class Program
    {

        class Ogrenci
        {
            // Fields (alanlar)
            private string isim;
            private int yas;

            // Properties (özellikler)
            public string Isim
            {
                get { return isim; }
                set { isim = value; }
            }

            public int Yas
            {
                get { return yas; }
                set
                {
                    if (value >= 0)
                        yas = value;
                    else
                        Console.WriteLine("Yaş negatif olamaz.");
                }
            }

            // Constructor
            public Ogrenci(string isim, int yas)
            {
                this.isim = isim; // "this" ile alanlara erişim
                this.yas = yas;
            }

            // Method
            public void BilgileriGoster()
            {
                Console.WriteLine($"İsim: {this.isim}, Yaş: {this.yas}");
            }
        }
        static void Main(string[] args)
        {
                Ogrenci ogr1 = new Ogrenci("Ahmet", 20);
                ogr1.BilgileriGoster();

                Ogrenci ogr2 = new Ogrenci("Zeynep", -5); // Kapsülleme sayesinde kontrol edilir
                ogr2.Yas = 22;
                ogr2.BilgileriGoster();
        }
    }
}
