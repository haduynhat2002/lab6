namespace lab7.Properties
{
    public class Employees
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}