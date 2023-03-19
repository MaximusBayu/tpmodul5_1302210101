// See https://aka.ms/new-console-template for more information

using System.Globalization;
using tpmodul5_1302210101;

Console.WriteLine("Masukkan Nama: ");
HaloGeneric<string> haloGeneric = new HaloGeneric<string>();
string X = Console.ReadLine();
haloGeneric.sapaUser(X);

Console.WriteLine("Masukkan NIM: ");
string nim = Console.ReadLine();
DataGeneric<string> Y = new DataGeneric<string>(nim);
Y.PrintData();
