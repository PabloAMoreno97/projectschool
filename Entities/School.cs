namespace CoreSchool.Entities
{
    public class School
    {
        private string name;
        public int CreationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes Type { get; set; }
        public List<Course> Courses { get; set; }
        public string Name
        {
            get { return $"School: {name}"; }
            set { name = value.ToUpper(); }
        }

        public School(string name, int creationYear) => (Name, CreationYear) = (name, creationYear);
        public School(string name, int creationYear, SchoolTypes type, string country = "", string city = "")
        {
            (this.name, CreationYear) = (name, creationYear);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Name {this.name}, Type: {this.Type} {System.Environment.NewLine}Country: {this.Country} City: {this.City}";
        }
    }
}