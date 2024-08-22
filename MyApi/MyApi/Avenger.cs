namespace MyApi
{
    public class Avenger {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        
        public Avenger(int id, string name, int year)
        {
            Id = id;
            Name = name;
            Year = year;
        }
    }
}