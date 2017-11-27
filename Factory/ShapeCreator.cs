using System;

namespace designpatterns.Factory
{
    public abstract class ShapeCreator
    {
        public abstract IShape CreateCircle();
        public abstract IShape CreateRetangle();
    }    
}