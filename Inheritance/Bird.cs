using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird(bool CanFly, string Wings, bool Feathered, string Beak)
        {
            IsAlive = true;
            Adapts = "flies";
            Reproduces = true;
            Eats = "fish";
        }
        public bool CanFly { get; set; }
        public string Wings { get; set; }
        public bool Feathered { get; set; }
        public string Beak { get; set; }
    }
}
