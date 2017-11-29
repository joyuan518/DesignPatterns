using System;

namespace DesignPatterns.Factory
{
    public abstract class ShapeCreator
    {
        public abstract IShape CreateCircle();
        public abstract IShape CreateRetangle();
    }    
}