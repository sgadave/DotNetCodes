namespace BOL;

using System.ComponentModel.DataAnnotations;

[Serializable]
public class Credential{
    [Required]
    public string? UserName{get;set;}
    [Required]
    public string? Password{get;set;}

    public Credential(){

    }

    public Credential(string id,string password){
        this.UserName=id;
        this.Password=password;
    }
}