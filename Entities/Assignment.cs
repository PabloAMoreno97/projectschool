namespace CoreSchool.Entities
{
    public class Assignment
    {
        public string id { get; private set; }
        public string Name { get; set; }

        public Assignment() => id = Guid.NewGuid().ToString();
    }
}