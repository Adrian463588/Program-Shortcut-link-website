using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO
{
    class Entry
    {
        public string url;
        public string name;
        public string key;

        public Entry(string newUrl, string newName, string newKey)
        {
            url = newUrl;
            name = newName;
            key = newKey;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Entry[] entries = new Entry[]
            {
                new Entry("www.shopee.co.id", "shopee", "s"),
                new Entry("www.tokopedia.com", "tokopedia", "t"),
                new Entry("www.lazada.co.id", "lazada", "l"),
                new Entry("https://acadinfo.jteti.ugm.ac.id/", "acadinfo", "1"),
                new Entry("www.simaster.ugm.ac.id", "simaster", "2"),
                new Entry("www.elok.ugm.ac.id", "elok", "3"),
                new Entry("www.compressjpeg.com", "compress", "4")

            };


            Console.WriteLine("Ketikkan Kata Kunci dan Tekan Enter!");
            Console.WriteLine("Opsi situs");
          
            foreach(Entry entry in entries)
            {
                Console.WriteLine("\t " + entry.key + " - " + entry.name);
            }

            Console.WriteLine("\n masukkan kata kuncimu...");


            string userInput = Console.ReadLine();
            bool foundEntry = false;

            foreach (Entry entry in entries)
            {
                if(userInput == entry.key || userInput == entry.name)
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", entry.url);
                    foundEntry = true;
                    RestartApp();
                }
            }
            if(foundEntry == false)
            {
                Console.WriteLine("\n Kata kunci tidak terdapat di program, ingin mengulangi lagi ?(ketik sembarang untuk keluar)");
                Console.WriteLine("\ty - iya");
                Console.WriteLine("\n kata kuncimu ?");

                string choice = Console.ReadLine();

                if(choice == "y" || choice == "iya")
                {
                    RestartApp();
                }
            }


           
            Console.Read();
        }

        static void RestartApp()
        {
            Console.Clear();
            Main(null);
        }
    }
}
