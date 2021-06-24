namespace AnimalManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AnimalConnection<Animal> animalConnection = new AnimalConnection<Animal>();
            animalConnection.Add(new Dog() {Id = 1, Name = "Cho", Dob = "2010"});
            animalConnection.Add(new Cat() {Id = 2, Name = "Meo", Dob = "2001"});
            animalConnection.Add(new Cat() {Id = 3, Name = "Weo", Dob = "2011"});
            animalConnection.Remove(2);
            animalConnection.ShowInfomation();
        }
    }
}