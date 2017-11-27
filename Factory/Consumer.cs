using System;

namespace designpatterns.Factory
{
    public static class Consumer
    {
        private static ShapeCreator GetShapeCreator()
        {
            return new RedShapeCreator();
        }

        public static void Run()
        {
            var shapeCreator = GetShapeCreator();

            var circle = shapeCreator.CreateCircle();
            var retangle = shapeCreator.CreateRetangle();

            circle.ShowShape();
            retangle.ShowShape();
        }
    }
}