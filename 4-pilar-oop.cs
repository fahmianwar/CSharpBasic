using System;
					
public class Program
{
	public static void Main()
	{
		//Computer c = new Computer();
		Macintosh Mac1 = new Macintosh();
		Macintosh Mac2 = new Macintosh();
		
		Mac1.Power();
		Mac1.Operate();
		Mac1.Operate(1,2);
		Mac2.Power();
		Mac2.Operate();
		Mac2.Operate(4441,2);
	}
}

// Abstraction
public abstract class Computer{
	//Properti
	private bool powerStatus;
	
	//Encapsulation
	/*
	public bool PowerStatus{
		get{ return powerStatus; }
	
		set{ powerStatus = value; }
	}
	*/
	public bool PowerStatus{get; set;}
	
	
	public Computer(){
		PowerStatus = false;
	}
	
	//Fungsi
	public void Power(){
		if(PowerStatus == true){
			PowerStatus = false;
		}else{
			PowerStatus = true;
		}
	}
	
	//Ide/Abstrak
	public abstract void Operate();
}
// Inheritance
public class Macintosh : Computer{
	//Polymorphism
	/// Override
	public override void Operate(){
		if(PowerStatus == true){
		Console.WriteLine("MacOS StartUp");
		}
	}
	
	// Overload
	public  void Operate(int x, int y){
		if(PowerStatus == true){
		Console.WriteLine(x+y);
		}
	}
	
}
