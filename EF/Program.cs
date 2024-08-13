using EF;

class Program
{
	static void Main()
	{
		using(MyDatabase northwind= new())
		{
			// connection Test
			bool status = northwind.Database.CanConnect();
			if(status == false)
			{
				return;
			}
			Console.WriteLine(status);
			
			// Read All Category
			// ReadAllCategory(northwind);
			
			// Read All Employee
			ReadAllEmployee(northwind);
			
			// Create Employee
			CreateEmployee(northwind);
		}
	}
	private static void ReadAllCategory(MyDatabase northwind)
	{
		List<Category> categories = northwind.Categories.ToList();
		foreach(Category cat in categories)
		{
			Console.WriteLine($"{cat.CategoryId} : {cat.CategoryName} = {cat.Description}");
		}
	}
	public static void ReadAllEmployee(MyDatabase northwind)
	{
		List<Employee> employees = northwind.Employees.ToList();
		foreach(Employee employee in employees)
		{
			Console.WriteLine($"{employee.EmployeeId} : {employee.FirstName}");
		}
	}
	public static void CreateEmployee(MyDatabase northwind)
	{
		Employee employee = new Employee();
		employee.FirstName = "Nabilah";
		employee.LastName = "Hanun";
		northwind.Employees.Add(employee);
		northwind.SaveChanges();
	}
}

