using baithuchanh.Models;

public class Employee : Person
{
    public string EmployeeId { get; set; } // KHÔNG đặt [Key] ở đây!
    public int Age { get; set; }
}
