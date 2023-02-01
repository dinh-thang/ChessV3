using Chess.src.ApplicationCore.Constants;
using Chess.src.ApplicationCore.Interfaces;
using System.ComponentModel;

namespace Chess.src.ApplicationCore.GameObjects
{
    public abstract class GameObject : IIdentifiableObject
    {
        private string _imageFileName = "";
        private readonly GameObjectID _objectID;
        private int _x;
        private int _y;
        
        public GameObject()
        { 
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public GameObjectID ObjectID
        {
            get { return _objectID; }
        }

    }
}
