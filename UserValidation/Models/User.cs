namespace UserData;

public class User{

    public string UserId{get;set;}
    public string FName{get;set;}
    public string LName{get;set;}
    public string Address{get;set;}
    public string MobileNo{get;set;}

    public User(string userId,string fName,string lName,string address,string mobileNo){
        this.UserId=userId;
        this.FName=fName;
        this.LName=lName;
        this.Address=address;
        this.MobileNo=mobileNo;
    }

}