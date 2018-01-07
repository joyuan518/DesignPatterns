namespace DesignPatterns.Composite
{
    using System;
    
    public class Button : Component
    {
        public override void Render()
        {
            Console.WriteLine($"Render the button with id {this.Id}.");
        }
    }
}