namespace Interfaces
{
    internal interface IMovable : IPositionable
    {
        public void Move(int deltaTop, int deltaLeft);
        public bool TryMove(int deltaTop, int deltaLeft);
        public bool CanMove(int deltaTop, int deltaLeft);
        public void UndoMove();
    }
}