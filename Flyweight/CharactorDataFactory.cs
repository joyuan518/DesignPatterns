namespace DesignPatterns.Flyweight
{
    using System.Collections.Generic;
    
    public static class CharactorDataFactory
    {
        private static readonly object _syncRoot = new object();
        private static readonly IDictionary<char, LatticeData> _sharedShapeData = new Dictionary<char, LatticeData>();

        public static CharactorData GetCharactorData(char charactor, int pointSize, int color)
        {            
            lock(_syncRoot)
            {
                if (!_sharedShapeData.ContainsKey(charactor))
                {
                    _sharedShapeData.Add(charactor, new LatticeData(charactor));
                }
            }

            return new CharactorData(charactor, pointSize, color, _sharedShapeData[charactor]);
        }
    }
}