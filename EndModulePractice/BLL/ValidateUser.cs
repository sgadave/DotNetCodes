namespace BLL;
using BOL;
using DAL;

public class ValidateUser
{
    public static bool Validation(string id, string password)
    {
        List<Credential> credlist = SerializeDeserialize.Deserialize();
        foreach (Credential cred in credlist)
        {
            if (id == cred.UserName && password == cred.Password)
            {
                return true;
            }
        }
        return false;
    }

    public static bool Register(string id, string password)
    {
        Credential credl = new Credential(id, password);
        SerializeDeserialize.SerializeData(credl);
        return true;
    }


    public static bool AlreadyRegistered(string id, string password)
    {
        List<Credential> credlist = SerializeDeserialize.Deserialize();
        foreach (Credential cred in credlist)
        {
            if (id == cred.UserName && password == cred.Password)
            {
                return true;
            }
        }
        return false;
    }


}



