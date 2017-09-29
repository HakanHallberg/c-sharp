using System;

namespace PartLib
{
    public class Part
    {
        public Part(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public override string ToString()
        {
            return $"{Name} ({ID})";

        }
    }
}
