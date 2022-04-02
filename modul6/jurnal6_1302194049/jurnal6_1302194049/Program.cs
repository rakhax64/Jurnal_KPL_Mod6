using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal6_1302194049
{
    internal class Program
    {
        static void Main(string[] args)
        {
			String jsonString = File.ReadAllText("C://users//nanda////source//repos//jurnal6_1302194049");

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
        
    

