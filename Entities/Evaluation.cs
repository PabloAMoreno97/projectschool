namespace CoreSchool.Entities
{
    public class Evaluation
    {
        public string id { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Assignment Assignment { get; set; }
        public float Calification { get; set; }

        public Evaluation() => id = Guid.NewGuid().ToString();
    }
}