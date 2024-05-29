 
static void Main(string[] args)
        {
            //www.yazilimkodlama.com
            int adet;
            Console.Write("Girilecek Veri Adeti : ");
            adet = Convert.ToInt16(Console.ReadLine());
 
            Console.WriteLine("---------------------------------------");
            string[] liste = new string[adet];
            string isim;
 
            for (int i = 0; i < adet; i++)
            {
                Console.Write(i + 1 + ". İsmi Giriniz: ");
                isim = Console.ReadLine();
                liste[i] = isim;
            }
 
            Console.WriteLine();
            Console.WriteLine("Sıralamadan önce liste:");
            Console.WriteLine("---------------------------------------");
 
            foreach (string eleman in liste)
            {
                Console.WriteLine(eleman);
            }
                
 
            Array.Sort(liste);
            Console.WriteLine();
            Console.WriteLine("A-Z Sıralama:");
            Console.WriteLine("---------------------------------------");
 
            foreach (string eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine();
            Array.Reverse(liste);
            Console.WriteLine("Z-A Sıralama:");
            Console.WriteLine("---------------------------------------");
 
            foreach (string eleman in liste)
            {
                Console.WriteLine(eleman);
            }
 
            Console.ReadKey();
        }
 