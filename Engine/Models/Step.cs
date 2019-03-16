namespace Engine.Models
{
    public class Step
    {
        public string Description { get; }

        public Step(string description)
        {
            Description = description;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
