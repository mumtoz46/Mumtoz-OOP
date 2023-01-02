using System.IO.Enumeration;
public class Employee
{
    private int id;
    private string firstName;
    private string lastName;
    private int salary;
    public Employee(int id,string firstName, string lastName, int salary)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }
    public int GetId()
    {
        return id;
    }
    public string FirstName()
    {
        return firstName;
    }
    public string GetLastName()
    {
        return lastName;
    }
    public string GetName()
    {
        return $"{firstName} {lastName}";
    }
    public int GetSalary()
    {
        return salary;
    }
    public void SetSalary(int salary)
    {
        this.salary = salary;
    }
    public int GetAnualSalary()
    {
        return salary * 12;
    }
    public int RaiseSalary(int percent)
    {
        return (salary / 100 * percent) * salary;
    }
    public override string ToString()
    {
        return $"Employee [{id} {firstName} {lastName} {salary}]";
    }
}