namespace UserDataSerialization;
using UserCredential;
using System.Text.Json;
using System.Collections.Generic;
using UserData;

public static class SerializerDeserializer
{

    static string credentialFile = @"D:\Github data\DotNet\UserValidation\wwwroot\database\Credentials.json";
    static string userDetailFile = @"D:\Github data\DotNet\UserValidation\wwwroot\database\UserDetails.json";

    public static List<Credential> DeserializerCredentials()
    {
        string credentialString = File.ReadAllText(credentialFile);
        List<Credential> credentialsList = JsonSerializer.Deserialize<List<Credential>>(credentialString)!;
        return credentialsList;
    }
    public static List<User> DeserializerUserDetails()
    {
        string userDetailString = File.ReadAllText(userDetailFile);
        List<User> userDetialsList = JsonSerializer.Deserialize<List<User>>(userDetailString)!;
        return userDetialsList;
    }

    public static Boolean ValidateUser(string userId, string password)
    {
        List<Credential> userCredentials = DeserializerCredentials();
        foreach (Credential user in userCredentials)
        {
            if (user.UserId == userId && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }

    public static Boolean RegisterUser(string userId, string password, string fName, string lName, string address, string mobileNo)
    {

        Credential cred = new Credential(userId, password);
        User userDetails = new User(userId,fName, lName, address, mobileNo);
        List<Credential> userCredentials = DeserializerCredentials();
        List<User> userDetailsList = DeserializerUserDetails();
        userCredentials.Add(cred);
        userDetailsList.Add(userDetails);

        var options = new JsonSerializerOptions { IncludeFields = true };
        var credentialsJson = JsonSerializer.Serialize<List<Credential>>(userCredentials, options);
        var userDetailsJson = JsonSerializer.Serialize<List<User>>(userDetailsList, options);

        File.WriteAllText(credentialFile, credentialsJson);
        File.WriteAllText(userDetailFile, userDetailsJson);
        return true;
    }
}