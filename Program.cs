using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace UASKasir
{

    /// <summary>
    /// //membuat public class
    /// </summary>
    
    public class KasirGhani
    {
        public void KasirGue()
        {
            {

                ///<summary>
                /////menampilkan selamat datang d icaffe Deeptalk 
                ///</summary>


                Console.WriteLine("===============================================");
                Console.Write("\n");
                Console.WriteLine("     Selamat Datang Di Kasir Caffe Deeptalk    ");
                Console.Write("\n");
                Console.WriteLine("===============================================");
                Console.Write("\n");
                Console.WriteLine("Pilih item dari menu");
                Console.Write("\n");
                /// <summary>
                /// menampilkan menu makanan
                /// </summary>
                Console.WriteLine("=================== Makanan ===================");
                Console.WriteLine("1. Roti Makan Hati               :  Rp 13000");
                Console.WriteLine("2. Nasi Goreng Cinta             :  Rp 12000");
                Console.WriteLine("3. Spageti Cuek                  :  Rp 16000");
                Console.WriteLine("4. Mie Selingkuhin               :  Rp 12000");
                Console.WriteLine("5. Kentang Hati                  :  Rp 10000");
                Console.Write("\n");
                /// <summary>
                /// menampilkan menu minuman
                /// </summary>

                Console.WriteLine("=================== Minuman ===================");
                Console.WriteLine("1. Kopi Lain Hati                :  Rp 17000");
                Console.WriteLine("2. Kopi Latte Hati               :  Rp 24000");
                Console.WriteLine("3. Kopi Anti Galau               :  Rp 26000");
                Console.WriteLine("4. Matcha Latte                  :  Rp 24000");
                Console.WriteLine("5. Kopi Surga                    :  Rp 22000");
                int jumlah;
                //looping dengan memasukkan jumlah barang menggunakan kondisi do while
                do
                {
                    Console.Write("\nMasukkan jumlah pesanan        :  ");
                    jumlah = int.Parse(Console.ReadLine());
                } while (jumlah <= 0 || jumlah > 100);
                //mendeklarasikan atau mendefinisikan variabel data
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;
                //menampilkan 'Masukkan nama pelanggan'
                Console.WriteLine("===============================================");
                Console.Write("Masukkan nama Customer : ");
                //deklarasi variabel data string
                string namap1 = Console.ReadLine();
                //looping menggunakan kombinasi array
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //menampilkan input nama barang
                        Console.WriteLine("===============================================");
                        Console.Write("\n");
                        Console.Write("Masukkan nama barang ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    } //user harus menginput nama barang di atas 0 karakter sampai dengan 20 karakter
                    while (nama[i].Length <= 0 || nama[i].Length >= 20);

                    do
                    {
                        Console.Write("Masukkan harga barang ke-" + (i + 1) + ": ");

                        harga[i] = int.Parse(Console.ReadLine());
                        //user harus menginput harga barang minimal 4000 sampai 1000000
                    }
                    while (harga[i] <= 4000 || harga[i] >= 1000000);
                }
                //menampilkan barang dan harga yang sudah dipilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("===============================================");
                Console.WriteLine("           Daftar Menu yang Dipilih            ");
                Console.WriteLine("===============================================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }
                /// <summary>
                /// <param name="nama"
                /// <para harga="harga"
                /// <para name="jumlah"
                /// menampilkan total harga
                /// </summary>
               
                Console.WriteLine("===============================================");
                Console.WriteLine("Total harga                     :  Rp" + total);
                do
                {
                    Console.Write("Masukkan uang bayar             :  Rp");
                    bayar = int.Parse(Console.ReadLine());
                    //menampilkan kembalian uang dari uang yang dibayarkan dikurangi uang total
                    kembalian = bayar - total;
                    //kondisi jika input uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Uang anda tidak cukup!");
                    }
                    //kondisi dimana input uang yang dibayarkan lebih
                    else //menampilkan uang kembalian
                    {
                        Console.WriteLine("Jumlah uang kembali             :  Rp" + kembalian);
                    }
                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Customer       : {0}", namap1.ToString());
                Console.Write("\n");
                //menampilkan tanggal dan waktu transaksi
                Console.WriteLine("Tanggal transaksi    : " + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam transaksi        : " + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("===============================================");
                Console.WriteLine("Nama kasir           : Maman Rokhman ");
                Console.WriteLine("================ Terima kasih =================");
                //mencetak nota menggunakan streamwriter
                using (StreamWriter sw = new StreamWriter(@"D://Nota.txt"))
                {
                    sw.WriteLine("===============================================");
                    sw.WriteLine("=============== Nota Pembayaran ===============");
                    sw.WriteLine("===============================================");
                    sw.WriteLine("             Nama Menu yang Dibeli             ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                    }
                    sw.WriteLine("===============================================");
                    sw.WriteLine("Total harga                     :  Rp" + total);
                    sw.WriteLine("Uang bayar                      :  Rp" + bayar);
                    sw.WriteLine("Uang kembali                    :  Rp" + kembalian);
                    sw.WriteLine("\n");
                    //menampilkan nama pelanggan
                    sw.WriteLine("Nama pelanggan    : {0}", namap1.ToString());
                    //menampilkan tanggal dan waktu transaksi
                    sw.WriteLine("Tanggal transaksi    : " + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam transaksi        : " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("===============================================");
                    sw.WriteLine("Nama kasir           : Maman Rokhman ");
                    sw.WriteLine("================ Terima kasih =================");
                    Console.Write("\n");
                    Console.WriteLine("Nota berhasil dicetak");
                }
                Console.WriteLine();
                Console.Write("Tekan ENTER/return untuk keluar");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            ///<summary>
            ///memanggil kelas KasirChuu
            ///</summary>
           
            KasirGhani KasirC = new KasirGhani();
            KasirC.KasirGue();
        }
    }
}