using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

class DataMahasiswa
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }

    public static void ReadJson()
    {
        using (StreamReader r = new StreamReader("jurnal6_1_1302194027.json"))
        {
            string json = r.ReadToEnd();
            DataMahasiswa items = JsonConvert.DeserializeObject<DataMahasiswa>(json);

            Console.Write("Name: {0}", items.firstName);
            Console.WriteLine(" {0}", items.lastName);
            Console.WriteLine("Gender: {0}", items.gender);
            Console.WriteLine("Age: {0}", items.age);
            Console.Write("Address: {0}", items.address.streetAddress);
            Console.Write(", {0}", items.address.city);
            Console.WriteLine(", {0}", items.address.state);
        }
    }
}

public class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Program
{
    

    public static void Main(string[] args)
    {
        DataMahasiswa.ReadJson();
    }
}

