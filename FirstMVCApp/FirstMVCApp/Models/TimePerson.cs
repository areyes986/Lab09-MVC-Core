using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class TimePerson
    {
		public int Year { get; set; }
		public string Honor { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int BirthYear { get; set; }
		public int DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }

		public static List<TimePerson> GetPersons(int begYear, int endYear)
		{

			List<TimePerson> persons = new List<TimePerson>();
			string[] peopleList = File.ReadAllLines(@"personOfTheYear.csv");
			//tranverse through the string for each line item
			foreach (var item in peopleList)
			{

				string[] splittedItems = item.Split(",");

				TimePerson person = new TimePerson();

				person.Year = int.Parse(splittedItems[0]);
				person.Honor = splittedItems[1];
				person.Name = splittedItems[2];
				person.Country = splittedItems[3];
				person.BirthYear = int.Parse(splittedItems[4]);
				person.DeathYear = int.Parse(splittedItems[5]);
				person.Title = splittedItems[6];
				person.Category = splittedItems[7];
				person.Context = splittedItems[8];

				persons.Add(person);
			}
				var query = from people in persons
							select people.Year;
			// csv is delimiited by commas
			// use ling to filter out the years brought in against your list of persons
			//return your list of persons
			return persons;
		}		


	}
}
