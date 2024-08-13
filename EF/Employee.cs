using System.ComponentModel.DataAnnotations;

namespace EF
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string FirstName { get; set; } = null!;
	}
}