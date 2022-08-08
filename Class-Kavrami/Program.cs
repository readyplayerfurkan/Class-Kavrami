using System;

namespace Sınıf
{
    class Program
    {
        static void Main()
        {
            Calisan calisan1 = new Calisan();

            calisan1.Adi = "Furkan";
            calisan1.Soyadi = "Yılmaz";
            calisan1.No = 0555412184;
            calisan1.Departman = "Yazılım";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan2 = new Calisan();

            calisan2.Adi = "Faruk";
            calisan2.Soyadi = "Yılmaz";
            calisan2.No = 52335320;
            calisan2.Departman = "Güvenlik";

            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Adi;
        public string Soyadi;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın adı:{0}", Adi);
            Console.WriteLine("Çalışanın soyadı:{0}", Soyadi);
            Console.WriteLine("Çalışanın numarası:{0}", No);
            Console.WriteLine("Çalışanın departmanı:{0}", Departman);
        }
    }
}