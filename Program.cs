

using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302194043
{
    internal class DataMahasiswa1302201138
    {

        public class Personal
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string age { get; set; }
            public Address address { get; set; }
            public Cours[] courses { get; set; }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Cours
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public void ReadJSON()
        {
            string file = "jurnal6_1_1302194043.json";
            string strFile = File.ReadAllText(file);
            Personal personal = JsonSerializer.Deserialize<Personal>(strFile);


            Console.WriteLine($"Mahasiswa {personal.firstName} {personal.lastName} berumur {personal.age} tahun, memiliki jenis kelamin {personal.gender}");

        }
    }
}