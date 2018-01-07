/* Tips: Component may have many other operation methods besides the Render() method.
   Thus "Composite" pattern can save the client a lot of unnecessary code to 
   deal with the difference between "Simple Component" and "Composite Component".
 */
namespace DesignPatterns.Composite
{
    using System;

    public abstract class Component
    {
        public string Id {get;} = Guid.NewGuid().ToString();

        public abstract void Render();
    }
}