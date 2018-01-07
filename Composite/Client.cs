namespace DesignPatterns.Composite
{
    using System;

    public static class Client
    {
        private static void RenderComponent(Component component)
        {
            component.Render();
        }

        public static void Run()
        {
            var panel = new Panel();

            panel.AddChild(new TextBox());
            panel.AddChild(new Button());

            RenderComponent(panel);
        }        
    }
}