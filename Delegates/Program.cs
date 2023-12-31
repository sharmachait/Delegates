﻿using Delegates.Examples;

namespace Delegates
{
	public delegate void hello();
	public class Program
	{
		public static void Hello1()
		{
			Console.WriteLine("Hello1");
		}
		public static void Hello2()
		{
			Console.WriteLine("Hello2");
		}
		static void Main(string[] args)
		{
			List<Employee> Employees = new List<Employee>();
			Employees.Add(new Employee { ID=1,Experience=3,Salary=10000,Name="Chaitanya"});
			Employees.Add(new Employee { ID=2,Experience=4,Salary=10000,Name="Kanhaiya"});
			Employees.Add(new Employee { ID=3,Experience=5,Salary=10000,Name="Charu"});
			Employees.Add(new Employee { ID=4,Experience=6,Salary=10000,Name="Rishu"});

			PromotioCriteria pc = new PromotioCriteria(PromoteInSix);
			BetterExample.BetterPromotion(Employees,pc);
			BetterExample.BetterPromotion(Employees, (x) => x.Experience >= 5);

			hello h=new hello(Hello1);
			h += Hello2;
			h();
		}
		public static bool PromoteInSix(Employee emp)
		{
			if (emp.Experience >= 6) return true;
			return false;
		}
		
	}
}