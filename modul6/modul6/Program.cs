using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6
{
    internal class Program
    {
        static void Main(string[] args)
        {
			String jsonString = File.ReadAllText("D://Perkuliahan/Semester 6/Konstruksi Perangkat Lunak/Pratikum/modul6/modul6");

			dynamic data = JsonConvert.DeserializeObject(jsonString);



			Console.WriteLine("Nama : " + data.firstName + " " + data.lastName);
			Console.WriteLine("Gender : " + data.gender);
			Console.WriteLine("Umur : " + data.age);
			Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
			Console.WriteLine("Mata Kuliah : ");
			foreach (var item in data.courses)
			{
				Console.WriteLine();
				Console.WriteLine("Kode matkul : " + item.code);
				Console.WriteLine("Nama matkul : " + item.name);
			}
			Console.WriteLine();
		}
	}
}
