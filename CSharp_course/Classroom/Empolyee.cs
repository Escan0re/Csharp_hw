namespace Classroom;

public class Empolyee : Person
{
    public Empolyee(string name, int age, int salary) : base(name, age)
    {
        Salary = salary;
    }

    public int Salary { get; set; }
    
    public override string ToString()
    {
        return base.ToString() + $", Зарплата: {Salary}";
    }
}