using System;
					
public class Program
{
	public static void Main()
	{
		Person p1 = new Person();
		p1.Nama = "Tes";
		p1.Tinggi = 12;
		p1.Berat = 30;
		Person p2 = new Person("Jerry", 140, 50);
		p1.MemperkenalkanDiri();
		p2.MemperkenalkanDiri();
	}
}

// Class
public class Person
{
	public string Nama;
	public int Tinggi;
	public int Berat;
	
	public Person(){}
	
	public Person(string namaPerson, int tinggiPerson, int beratPerson){
		Nama = namaPerson;
		Tinggi = tinggiPerson;
		Berat = beratPerson;
	}
	
	public void MemperkenalkanDiri(){
		Console.WriteLine("Nama : " + Nama + " Tinggi : " + Tinggi + " Berat : " + Berat);
	}
}
