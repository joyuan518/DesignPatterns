namespace DesignPatterns.Composite
{
    using System;
    using System.Collections.Generic;

    public class Panel : Component
    {
        private readonly List<Component> _chidrenComponents = new List<Component>();

        public override void Render()
        {
            foreach (var child in this._chidrenComponents)
            {
                child.Render();
            }
        }

        public void AddChild(Component child)
        {
            this._chidrenComponents.Add(child);
        }

        public Component FindChildById(string id) => this._chidrenComponents.Find(c => c.Id == Id);
    }
}