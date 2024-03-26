using System;

namespace SistemMenggambar
{
    
    interface IShape
    {
        void Draw();
    }

    
    class Shape : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Menggambar bentuk umum...");
        }
    }

    
    class Segitiga : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar segitiga...");
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");
        }
    }

    
    class Lingkaran : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar lingkaran...");
            Console.WriteLine("    * *  *");
            Console.WriteLine("  *        *");
            Console.WriteLine(" *           *");
            Console.WriteLine("*             *");
            Console.WriteLine("*             *");
            Console.WriteLine(" *            *");
            Console.WriteLine("  *         * ");
            Console.WriteLine("     *  *");
        }
    }

    
    class Persegi : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar persegi...");
            Console.WriteLine("******");
            Console.WriteLine("*    *");
            Console.WriteLine("******");
        }
    }

    
    class PersegiPanjang : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar persegi panjang...");
            Console.WriteLine("********");
            Console.WriteLine("*      *");
            Console.WriteLine("********");
        }
    }

    
    class JajarGenjang : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Menggambar jajar genjang...");
            Console.WriteLine("   **********");
            Console.WriteLine("  *        *");
            Console.WriteLine(" *        *");
            Console.WriteLine(" **********");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Media mu : \n 1.Kertas Canvas ");
            string canvas = Console.ReadLine();
            if (canvas.ToUpper() == "1")
            {
                Console.WriteLine("pilih gambar yang kalian inginkan.. \n 1. Segitiga \n 2. Lingkaran \n 3. Persegi \n 4. Persegi Panjang \n 5. Jajar Genjang");
                string pilih = Console.ReadLine();
                Shape shape = null;
                switch (pilih)
                {
                    case "1":
                        shape = new Segitiga();
                        break;
                    case "2":
                        shape = new Lingkaran();
                        break;
                    case "3":
                        shape = new Persegi();
                        break;
                    case "4":
                        shape = new PersegiPanjang();
                        break;
                    case "5":
                        shape = new JajarGenjang();
                        break;
                    default:
                        Console.WriteLine("coba lagi..pilihan yang anda pilih zonk");
                        break;
                }
                shape.Draw();
            }
            else
            {
                Console.WriteLine("Invalid guys");
            }

            
        }
    }
}

