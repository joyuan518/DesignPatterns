using System;

namespace DesignPatterns.Factory
{
    public class RedShapeCreator : ShapeCreator
    {
        public override IShape CreateCircle()
        {
            return new RedCircle();
        }

        public override IShape CreateRetangle()
        {
            return new RedRetangle();
        }
    }    
}