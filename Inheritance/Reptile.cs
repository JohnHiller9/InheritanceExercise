using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile(bool ColdBlooded, string ScaleColor, bool Tail, string Habitat)
        {
            IsAlive = true;
            Adapts = "crawls";
            Reproduces = true;
            Eats= "bugs";
        }
        public bool ColdBlooded { get; set; }
        public string ScaleColor { get; set; }       
        public bool Tail { get; set; }
        public string Habitat { get; set; }
    }
}
