using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesKreditPlus {
    class Program {
        static void Main(string[] args) {
            // Nomor 1
            int a = 5;
            int b = 3;
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Hasil pertukaran");
            Console.WriteLine("Nilai a = " + a);
            Console.WriteLine("Nilai b = " + b);

            // Nomor 2
            int[] x = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };
            int temp = 0;
            for (int i = 0; i < x.Length; i++) {
                for (int j = 0; j < x.Length; j++) {
                    if (x[i] < x[j]) {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nUrutan nilai dari kecil ke terbesar");
            foreach (int item in x) {
                Console.WriteLine(item);
            }

        }
    }
}
