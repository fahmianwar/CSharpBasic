using System;
using System.Collections.Generic;

					
public class Program
{
	public static void Main()
	{
		// VARIABLE
		/*
		string nama= "Budi";
		int myNum = 5;
		double myDoubleNum = 5.99;
		char myLetter = 'D';
		bool myBool = true;
		string myText = "Halo";
		Console.WriteLine(myDoubleNum);
		*/
		
		// CONSTANTA
		/*
		const double Phi = 3.14;
		//Phi = 5.32
		Console.WriteLine(Phi);
		*/
		
		// OPERATOR
		/*
		int hasil = 100 + 50;
		Console.WriteLine(hasil);
		*/
		
		// ARRAY
		/*
		string[] mobil = {"Volvo", "BMW", "Ford", "Mazda"};
		int[] angka = {10, 20, 30, 40};
		//mobil[0] = "Tesla";
		Console.WriteLine(mobil[0]);
		*/
		
		// LIST
		/*
		List<string> penulis = new List<string>(5);  
		string[] hewan = { "Sapi", "Unta", "Gajah" };  
		List<string> listHewan = new List<string>(hewan); 
		
		List<int> listAngka= new List<int>();  
		listAngka.Add(1); 
		
		int[] angkaBaru= {2,3,4,5};  
		listAngka.AddRange(angkaBaru);
		
		listHewan.Remove("Sapi");
		listHewan.RemoveAt(1);
		listHewan.RemoveRange(0,1); 
		listHewan.Clear(); 
		
		List<string> listHuruf = new List<string> {"abc", "123", "ghi"};
		//listHuruf[1] = "def";
		//listHuruf[listHuruf .FindIndex(index=>index.Equals("123"))] =  "def";
		Console.WriteLine(listHuruf[1]);
		*/
		
		// ITERATION
		// While Loop
		/*
		int i = 0;
		while(i <5)
		{
		   Console.WriteLine(i);
		   i ++;
		}
		
		// For
		for(int o = 0; o <5; o++)
		{
		   Console.WriteLine(o);
		}

		// Foreach
		foreach (string kendaraan in mobil)
		{
		   Console.WriteLine(kendaraan);
		}
		*/

		// EXCEPTION HANDLING
		/*
		try
		{
		  int[] myNumbers = {1, 2, 3};
		  Console.WriteLine(myNumbers[10]);
		}
		catch (Exception e)
		{
		  Console.WriteLine(e.Message);
		  //Console.WriteLine("Ada yang salah");
		}
		*/
		// METHOD
		/*
		  HaloDunia();
		  Console.WriteLine(Penjumlahan(3,2));
		*/
	}
	// METHOD
	// Void
	
	static void HaloDunia() 
	{
	  Console.WriteLine("Halo Dunia!");
	}
	
	// Non-Void
	static int Penjumlahan(int x, int y) 
	{
	  return x+y;
	}
	
}
