namespace Crud30_06_25.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required String Name { get; set; }
        public string? Salary { get; set; }
        public String? address { get; set; }
    }
}
