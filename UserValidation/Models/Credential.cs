namespace UserCredential;


public class Credential{
    public string UserId{get;set;}
    public string Password{get;set;}

    public Credential(string userId,string password){
        this.UserId=userId;
        this.Password=password;
    }
}