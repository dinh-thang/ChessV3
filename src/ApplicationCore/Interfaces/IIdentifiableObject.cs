using Chess.src.ApplicationCore.Constants;

namespace Chess.src.ApplicationCore.Interfaces
{
    public interface IIdentifiableObject
    {
        int X { get; }
        int Y { get; }
        GameObjectID ObjectID { get; }
    }
}
