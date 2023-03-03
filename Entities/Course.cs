namespace CoreSchool.Entities
{
    public class Course
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public Schedule Schedule { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Student> Students { get; set; }
        public float Calification { get; set; }
        public Course() => Id = Guid.NewGuid().ToString();
    }
}