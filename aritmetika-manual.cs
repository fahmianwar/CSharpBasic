using System;
					
public class Program
{

	public static void Main()
	{
		int nilaiPertambahan = Pertambahan(1,2);
		
		//Latihan
		//int nilaiPerkalian = Perkalian(nilaiPertambahan, 4); // tidak boleh menggunakan arithmatic / assignment operator
      	//Perpangkatan(nilaiPerkalian, 2); // tidak boleh menggunakan arithmatic / assignment operator
      	//Faktorial(9);
		///Console.WriteLine(Perkalian(10,10));
		Console.WriteLine(Perpangkatan(12,4));
		//Faktorial(9);
	}
	
	static int Pertambahan(int x, int y){
		return x + y;
	}
	
	static int Perkalian(int x, int y){
		int result = 0;
		for(int i= 0; i < y; i++){
			result = Pertambahan(result, x);
		}
		return result;
	}
	
	static int Perpangkatan(int x, int y){
		int result = 1;
		//result = Math.Pow(x,y);
		if(y == 0){
			return 1;
		}else if(y == 1){
			return x;
		}else{
			for(int i = 1; i <= y; i++){
				result = Perkalian(result,x);
			}
			return result;
		}
	}
	
	static void Faktorial(int x){
		int result = 1;
		for(int i = 1; i <= x; i++){
			result = Perkalian(result,i);
		}
		Console.WriteLine(result);
	}
	
}
