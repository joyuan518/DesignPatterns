namespace DesignPatterns.Composite
{
    using System;

    public class TextBox : Component
    {
        public override void Render()
        {
            Console.WriteLine($"Render the text box with id {this.Id}.");
        }
    }
}