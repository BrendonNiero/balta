using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<Paciente> pacientes = new List<Paciente>
			{
			  new Paciente(1, "Brendon", 21),
			  new Paciente(2, "Julia", 20)
			};
			
			var novaLista = pacientes.Where(p => p.Age >= 11);
			 
			foreach(var paciente in novaLista)
			{
			  Console.WriteLine(paciente.Id);
			}
		}
	}
	
	public class Paciente
	{
	  public int Id { get; set; }
	  public string Name { get; set; }
	  public int Age { get; set; }
	  
	  public Paciente(int id, string name, int age)
	  {
	    Id = id;
	    Name = name;
	    Age = age;
	  }
	}
}
