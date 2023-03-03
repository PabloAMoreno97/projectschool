namespace CoreSchool.Entities
{
    public class Student
    {
        public string Id { get; private set; }
        public string Name { get; set; }

        public Student() => Id = Guid.NewGuid().ToString();
    }
}