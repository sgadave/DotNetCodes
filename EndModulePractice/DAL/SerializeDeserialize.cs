namespace DAL;
using System.Text.Json;
using BOL;

public class SerializeDeserialize
{
    private static string pathString = @"D:\PersonalProjects\EndModulePractice\Credentials.json";

    public static void SerializeData(Credential cred)
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        List<Credential> credList = Deserialize();
        credList.Add(cred);
        string str = JsonSerializer.Serialize<List<Credential>>(credList, options);
        File.WriteAllText(pathString, str);
    }

    public static List<Credential> Deserialize()
    {
        List<Credential> credList = new List<Credential>();
        string cred = File.ReadAllText(pathString);
        credList = JsonSerializer.Deserialize<List<Credential>>(cred)!;
        return credList;
    }
}