using System;
using System.Collections.Generic;

namespace TugasCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // === TUGAS FOR ===
            Console.WriteLine("=== FOR 1 ===");
            For1();

            Console.WriteLine("
=== FOR 2 ===");
            For2();

            Console.WriteLine("
=== FOR 3 ===");
            For3();

            Console.WriteLine("
=== FOR 4 ===");
            For4();

            Console.WriteLine("
=== FOR 5 ===");
            For5();

            // === TUGAS WHILE ===
            Console.WriteLine("
=== WHILE 1 ===");
            While1();

            Console.WriteLine("
=== WHILE 2 ===");
            While2();

            Console.WriteLine("
=== WHILE 3 ===");
            While3();

            Console.WriteLine("
=== WHILE 4 ===");
            While4();

            Console.WriteLine("
=== WHILE 5 ===");
            While5();

            // === TUGAS DO WHILE ===
            Console.WriteLine("
=== DO WHILE 1 ===");
            DoWhile1();

            Console.WriteLine("
=== DO WHILE 2 ===");
            DoWhile2();

            Console.WriteLine("
=== DO WHILE 3 ===");
            DoWhile3();

            Console.WriteLine("
=== DO WHILE 4 ===");
            DoWhile4();

            Console.WriteLine("
=== DO WHILE 5 ===");
            DoWhile5();

            // === TUGAS FOREACH ===
            Console.WriteLine("
=== FOREACH 1 ===");
            Foreach1();

            Console.WriteLine("
=== FOREACH 2 ===");
            Foreach2();

            Console.WriteLine("
=== FOREACH 3 ===");
            Foreach3();

            Console.WriteLine("
=== FOREACH 4 ===");
            Foreach4();

            Console.WriteLine("
=== FOREACH 5 ===");
            Foreach5();

            // === TUGAS ARRAY ===
            Console.WriteLine("
=== ARRAY 1 ===");
            Array1();

            Console.WriteLine("
=== ARRAY 2 ===");
            Array2();

            Console.WriteLine("
=== ARRAY 3 ===");
            Array3();

            Console.WriteLine("
=== ARRAY 4 ===");
            Array4();

            Console.WriteLine("
=== ARRAY 5 ===");
            Array5();

            // === TUGAS LIST ===
            Console.WriteLine("
=== LIST 1 ===");
            List1();

            Console.WriteLine("
=== LIST 2 ===");
            List2();

            Console.WriteLine("
=== LIST 3 ===");
            List3();

            Console.WriteLine("
=== LIST 4 ===");
            List4();

            Console.WriteLine("
=== LIST 5 ===");
            List5();

            Console.ReadLine();
        }

        // --- FOR ---
        static void For1()
        {
            Console.WriteLine("=== Angka 1-10 ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Angka ke-" + i);
            }
        }

        static void For2()
        {
            Console.WriteLine("=== Bilangan Genap 2-20 ===");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine("Genap: " + i);
            }
        }

        static void For3()
        {
            Console.WriteLine("=== Hitung Mundur ===");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Detik: " + i);
            }
            Console.WriteLine("Selesai!");
        }

        static void For4()
        {
            int total = 0;
            for (int i = 1; i <= 5; i++)
            {
                total += i;
            }
            Console.WriteLine("Total penjumlahan 1 sampai 5 adalah: " + total);
        }

        static void For5()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Saya belajar C# kelas X RPL");
            }
        }

        // --- WHILE ---
        static void While1()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Nilai i = " + i);
                i++;
            }
        }

        static void While2()
        {
            int angka = 1;
            while (angka < 10)
            {
                Console.WriteLine("Angka ganjil: " + angka);
                angka += 2;
            }
        }

        static void While3()
        {
            int n = 5;
            while (n <= 25)
            {
                Console.WriteLine("Kelipatan: " + n);
                n += 5;
            }
        }

        static void While4()
        {
            int count = 1;
            while (count <= 4)
            {
                Console.WriteLine("Semangat Belajar Pemrograman!");
                count++;
            }
        }

        static void While5()
        {
            int timer = 3;
            while (timer > 0)
            {
                Console.WriteLine("Waktu tersisa: " + timer);
                timer--;
            }
            Console.WriteLine("Mulai!");
        }

        // --- DO WHILE ---
        static void DoWhile1()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Angka: " + i);
                i++;
            } while (i <= 5);
        }

        static void DoWhile2()
        {
            int angka = 10;
            do
            {
                Console.WriteLine("Nilai awal: " + angka);
                angka++;
            } while (angka < 5);
        }

        static void DoWhile3()
        {
            int k = 1;
            do
            {
                Console.WriteLine("SMKN 2 Buduran");
                k++;
            } while (k <= 3);
        }

        static void DoWhile4()
        {
            int sum = 0;
            int n = 1;
            do
            {
                sum += n;
                n++;
            } while (n <= 4);
            Console.WriteLine("Hasil sum: " + sum);
        }

        static void DoWhile5()
        {
            int val = 2;
            do
            {
                Console.WriteLine("Perkalian 2: " + val);
                val += 2;
            } while (val <= 8);
        }

        // --- FOREACH ---
        static void Foreach1()
        {
            int[] deret = { 10, 20, 30, 40, 50 };
            foreach (int x in deret)
            {
                Console.WriteLine("Nilai: " + x);
            }
        }

        static void Foreach2()
        {
            string[] buah = { "Apel", "Jeruk", "Mangga", "Pisang" };
            foreach (string b in buah)
            {
                Console.WriteLine("Buah: " + b);
            }
        }

        static void Foreach3()
        {
            string kata = "SMK";
            foreach (char c in kata)
            {
                Console.WriteLine("Huruf: " + c);
            }
        }

        static void Foreach4()
        {
            double[] nilai = { 85.5, 90.0, 78.0, 88.5 };
            foreach (double n in nilai)
            {
                Console.WriteLine("Nilai ujian: " + n);
            }
        }

        static void Foreach5()
        {
            string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat" };
            foreach (string h in hari)
            {
                Console.WriteLine("Hari sekolah: " + h);
            }
        }

        // --- ARRAY ---
        static void Array1()
        {
            string[] siswa = { "Andi", "Budi", "Citra", "Dani", "Eva" };
            for (int i = 0; i < siswa.Length; i++)
            {
                Console.WriteLine("Siswa ke-" + (i + 1) + ": " + siswa[i]);
            }
        }

        static void Array2()
        {
            int[] nilai = new int[3];
            nilai[0] = 80;
            nilai[1] = 90;
            nilai[2] = 85;
            Console.WriteLine("Nilai pertama: " + nilai[0]);
            Console.WriteLine("Nilai kedua: " + nilai[1]);
            Console.WriteLine("Nilai ketiga: " + nilai[2]);
        }

        static void Array3()
        {
            int[] angka = { 70, 80, 90, 100 };
            int total = 0;
            for (int i = 0; i < angka.Length; i++)
            {
                total += angka[i];
            }
            double rataRata = (double)total / angka.Length;
            Console.WriteLine("Rata-rata: " + rataRata);
        }

        static void Array4()
        {
            char[] abjad = { 'A', 'B', 'C', 'D' };
            for (int i = 0; i < abjad.Length; i++)
            {
                Console.WriteLine("Abjad: " + abjad[i]);
            }
        }

        static void Array5()
        {
            string[] warna = { "Merah", "Kuning", "Hijau" };
            Console.WriteLine("Sebelum diubah: " + warna[0]);
            warna[0] = "Biru";
            Console.WriteLine("Setelah diubah: " + warna[0]);
        }

        // --- LIST ---
        static void List1()
        {
            List<string> siswa = new List<string>();
            siswa.Add("Andi");
            siswa.Add("Budi");
            siswa.Add("Citra");
            foreach (string s in siswa)
            {
                Console.WriteLine("Siswa: " + s);
            }
        }

        static void List2()
        {
            List<int> nomor = new List<int>() { 5, 10, 15, 20 };
            for (int i = 0; i < nomor.Count; i++)
            {
                Console.WriteLine("Nomor: " + nomor[i]);
            }
        }

        static void List3()
        {
            List<string> hewan = new List<string>() { "Kucing", "Anjing", "Kelinci" };
            hewan.Remove("Anjing");
            Console.WriteLine("Daftar hewan setelah dihapus:");
            foreach (string h in hewan)
            {
                Console.WriteLine("- " + h);
            }
        }

        static void List4()
        {
            List<string> mapel = new List<string>() { "Pemrograman C#", "Basis Data", "Jaringan" };
            Console.WriteLine("Jumlah mata pelajaran: " + mapel.Count);
            if (mapel.Contains("Pemrograman C#"))
            {
                Console.WriteLine("Mata pelajaran Pemrograman C# ada di dalam daftar.");
            }
        }

        static void List5()
        {
            List<int> skor = new List<int>() { 100, 200, 300 };
            Console.WriteLine("Jumlah skor awal: " + skor.Count);
            skor.Clear();
            Console.WriteLine("Jumlah skor setelah Clear(): " + skor.Count);
        }
    }
}
