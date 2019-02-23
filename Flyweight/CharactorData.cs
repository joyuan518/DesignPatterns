namespace DesignPatterns.Flyweight
{
    public class CharactorData
    {
        private readonly char _charactor;

        public CharactorData(char charactor, int pointSize, int color, LatticeData shapeData)
        {
            this._charactor = charactor;

            this.ShapeData = shapeData;
            this.PointSize = pointSize;
            this.Color = color;
        }

        #region Extrinsic State

        public char Charactor
        {
            get { return this._charactor; }
        } 

        public int PointSize {get; set;}

        public int Color {get; set;}

        #endregion

        #region Intrinsic State

        //The bitmap data about how the charactor should be drawn on the output device
        protected LatticeData ShapeData {get; set;} 

        #endregion

        public void Draw()
        {
            //Draw the charactor with the current properties of the charactor object(point size, color ...)
        }
    }
}