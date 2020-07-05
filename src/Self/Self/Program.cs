using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Self
{
    public class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			Int32 j = new Int32();

			Console.WriteLine($"{i}\n{j}");

			Person person1 = new Person();
			person1.firstName = "Илья";
			person1.secondName = "Козлов";

			Person person2 = new Person();
			person2.firstName = "Митя";
			person2.secondName = "Хрялов";

			var doctor = new Doctor();
			doctor.firstName = "Роман";
			doctor.Speciolization = "Педиатор";

			
			Console.WriteLine(person1.secondName += person1.firstName);
			Console.WriteLine(person2.firstName, person2.secondName);
            Console.WriteLine(doctor.Speciolization);

			Console.ReadKey();
		}
	}
}
