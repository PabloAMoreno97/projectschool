namespace CoreSchool.Entities
{
    public class Student
    {
        public string id { get; private set; }
        public string Name { get; set; }

        public Student() => id = Guid.NewGuid().ToString();
    }
}