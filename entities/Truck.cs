namespace fleetsystem.entities
{
    public class Truck{
        public int Id{
            get; set;
        }
        public string? Name {get; set;}//name may be empty get and set create getteres and setters automatically no lombok nothign as in java
        public string? Model{get; set;}
        public int Year{get; set;}
        public Truck(string name, string model, int year){
            Name = name;
            Model = model;
            Year = year;
        }

    }
}