using System;
					
public class Program
{
	public static void Main()
	{
		Yamaha yam = new Yamaha();
		Honda hon = new Honda();
		
		Console.WriteLine("YAMAHA");
		yam.Kunci();
		yam.Power();
		yam.Transmisi();
		yam.Gas();
		yam.TransmisiDepan();
		yam.Gas();
		yam.TransmisiDepan();
		yam.TransmisiDepan();
		yam.TransmisiDepan();
		yam.TransmisiDepan();
		yam.TransmisiDepan();
		yam.TransmisiBelakang();
		Console.WriteLine();
		
		Console.WriteLine("HONDA");
		hon.Kunci();
		hon.Power();
		hon.Transmisi();
		hon.TransmisiDepan();
		hon.TransmisiDepan();
		hon.TransmisiDepan();
		hon.TransmisiDepan();
		hon.TransmisiDepan();
		hon.TransmisiDepan();
		hon.TransmisiBelakang();
		hon.TransmisiBelakang();
		hon.TransmisiBelakang();
		hon.TransmisiBelakang();
		hon.TransmisiBelakang();

		hon.Gas();
		hon.TransmisiDepan();
		hon.Gas();
		hon.Kunci();
		
		hon.Power();
	}
}


public abstract class SepedaMotor{
	public bool KunciStatus{get; set;}
	public bool PowerStatus{get; set;}
	public int GearStatus{get; set;}
	
	public SepedaMotor(){
		PowerStatus = false;
		KunciStatus = false;
		GearStatus = 0;

	}
	
	public void Kunci(){
		if(KunciStatus){
			KunciStatus = false;
			Console.WriteLine("Sepeda Motor [Dimatikan]");
		}else{
			KunciStatus = true;
			
		}
	}
	
	public void Power(){
		if(KunciStatus){
			PowerStatus = true;
			Console.WriteLine("Sepeda Motor [Dihidupkan]");
		}
	}
	
	public abstract void Transmisi();
}


public class Yamaha : SepedaMotor{

	public override void Transmisi(){
		if(PowerStatus == true){
		Console.WriteLine("Status Gear Sepeda Motor Honda pada posisi ke-"+GearStatus);
		}
	}
	
	public void TransmisiDepan(){
		if(GearStatus>=0 && GearStatus <5){
		GearStatus++;
		Console.WriteLine("Posisi Gear Sepeda Motor Honda dipindakan ke-"+GearStatus);
		}else{
			Console.WriteLine("Posisi Gear Tidak Bisa dipindahkan");
		}
	}
	
	public void TransmisiBelakang(){
		if(GearStatus<=5 && GearStatus >0){
		GearStatus--;
			Console.WriteLine("Posisi Gear Sepeda Motor Honda dipindakan ke-"+GearStatus);
		} else {
			Console.WriteLine("Posisi Gear Tidak Bisa dipindahkan");
		}
	}
	
	public void Gas(){
		if(PowerStatus == true && GearStatus>=1){
		Console.WriteLine("Sepeda Motor Yamaha [Melaju]");
		}else{
			Console.WriteLine("Sepeda Motor Yamaha [Diam]");
		}
		
	}
	
}

public class Honda : SepedaMotor{
	
	public override void Transmisi(){
		if(PowerStatus == true){
		Console.WriteLine("Status Gear Sepeda Motor Honda pada posisi ke-"+GearStatus);
		}
	}

	public void TransmisiDepan(){
		if(GearStatus>=0 && GearStatus <5){
		GearStatus++;
		Console.WriteLine("Posisi Gear Sepeda Motor Honda dipindakan ke-"+GearStatus);
		}else{
			Console.WriteLine("Posisi Gear Tidak Bisa dipindahkan");
		}
	}
	
	public void TransmisiBelakang(){
		if(GearStatus<=5 && GearStatus >0){
		GearStatus--;
			Console.WriteLine("Posisi Gear Sepeda Motor Honda dipindakan ke-"+GearStatus);
		} else {
			Console.WriteLine("Posisi Gear Tidak Bisa dipindahkan");
		}
	}
	
	public void Gas(){
		if(PowerStatus == true && GearStatus>=1){
		Console.WriteLine("Sepeda Motor Honda [Melaju]");
		}else{
			Console.WriteLine("Sepeda Motor Honda [Diam]");
		}
		
	}
	
}
