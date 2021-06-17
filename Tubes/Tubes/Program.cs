using System;
using System.Collections.Generic;

namespace Tubes
{
    class Program
    {
        public static void Main(string[] args)
        {
            RunController run = new RunController();

            run.SetBiodata(new KTP("Arya", "Medan", "Pelajar"));
            run.DisplayText();
            Console.WriteLine("--------------------------------------------------------");
            run.SetBiodata(new Profile("1302194093", "Arya", "Jln. Pelabuhan Baru Bagansiapiapi, Riau"));
            run.DisplayText();
            Console.WriteLine("--------------------------------------------------------");
            run.SetBiodata(new Admin("Anonumous", "Jakarta", "Jln. bintang baru"));
            run.DisplayText();
            Console.WriteLine("--------------------------------------------------------");
            run.SetBiodata(new UserPenggunjung("Samsung", "Jakarta"));
            run.DisplayText();
         Console.ReadKey(true);
        }
    }

    interface Biodata
    {
        void DisplayText();
    }

    abstract class Controler
    {
        protected Biodata biodata;
        public void SetBiodata(Biodata biodata)
        {
            this.biodata = biodata;
        }
        public void DisplayText()
        {
            biodata.DisplayText();
        }
    }

    class RunController : Controler { }

    class KTP : Biodata
    {
        public KTP(string name, string alamat, string status_hubungan)
        {
            this.name = name;
            this.alamat = alamat;
            this.status_hubungan = status_hubungan;
        }

        private string name, alamat, status_hubungan;

        public void DisplayText()
        {
            Console.WriteLine("Class KTP implementasi dari interface Biodata\n");
            Console.WriteLine("Nama \t: " + name);
            Console.WriteLine("Alamat \t: " + alamat);
            Console.WriteLine("Status \t: " + status_hubungan);
            Console.WriteLine();
        }
    }

    class Profile : Biodata
    {
        public Profile(string nim, string nama, string alamat)
        {
            this.nim = nim;
            this.nama = nama;
            this.alamat = alamat;
        }

        private string nim, nama, alamat;

        public void DisplayText()
        {
            Console.WriteLine("Class Profile implementasi dari interface Biodata\n\n");
            Console.WriteLine("No. Induk \t: " + nim);
            Console.WriteLine("Nama \t\t: " + nama);
            Console.WriteLine("Alamat \t\t: " + alamat);
            Console.WriteLine();
        }
    }
    class Admin : Biodata
    {
        public Admin(string name, string kota, string alamat)
        {
            this.name = name;
            this.kota = kota;
            this.alamat = alamat;
        }

        private string name, kota, alamat;

        public void DisplayText()
        {
            Console.WriteLine("Class Admin implementasi dari interface Biodata\n");
            Console.WriteLine("Nama \t: " + name);
            Console.WriteLine("Kota \t: " + kota);
            Console.WriteLine("alamat \t: " + alamat);
            Console.WriteLine();
        }
    }
    class UserPenggunjung : Biodata
    {
        public UserPenggunjung(string name, string kota)
        {
            this.name = name;
            this.kota = kota;

        }

        private string name, kota;

        public void DisplayText()
        {
            Console.WriteLine("Class UserPenggunjun implementasi dari interface Biodata\n");
            Console.WriteLine("Nama \t: " + name);
            Console.WriteLine("Kota \t: " + kota);
            Console.WriteLine();
        }
    }
}


