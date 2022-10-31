using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace Interfaces
{
    internal class Furniture : IPositionable, IMovable
    {
        public int GetLeft()
        {
            throw new NotImplementedException();
        }

        public int GetTop()
        {
            throw new NotImplementedException();
        }

        bool IMovable.CanMove(int deltaTop, int deltaLeft)
        {
            throw new NotImplementedException();
        }

        void IMovable.Move(int deltaTop, int deltaLeft)
        {
            throw new NotImplementedException();
        }

        bool IMovable.TryMove(int deltaTop, int deltaLeft)
        {
            throw new NotImplementedException();
        }

        void IMovable.UndoMove()
        {
            throw new NotImplementedException();
        }
    }
}
