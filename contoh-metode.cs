using System;
                    
public class Program
{
    static string NewPassword = "123";
    static string OldPassword = "1234";
    
    public static void Main()
    {

        bool OldPasswordValue = CheckPassword(OldPassword);
        bool NewPasswordValue = IsPasswordTheSame(NewPassword, OldPassword);
        
        // old password -> benar
        // new password -> false (artinya dia tidak sama password dengan yang sebelumnya)
        if(OldPasswordValue != NewPasswordValue){
            ChangePassword(NewPassword);
        }
        Console.WriteLine(OldPassword);
    }
    
    static void ChangePassword(string x){
        OldPassword = x;
        Console.WriteLine("Password Berhasil di Ganti");
    }
    
          //value -> non-void
    static bool CheckPassword(string x){
        if(x == "1234"){
            return true;
        }
        else{
            return false;
        }
    }
    
    static bool IsPasswordTheSame(string x, string y){
        if(x == y){
        return true;
        }
        else{
        return false;
        }
    }
}
