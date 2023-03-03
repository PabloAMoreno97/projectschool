namespace CoreSchool.Entities
{
    public class Evaluation
    {
        public string id { get; private set; }
        public string Name { get; set; }

        public Evaluation() => id = Guid.NewGuid().ToString();
    }
}