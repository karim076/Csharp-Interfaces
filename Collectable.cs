using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces
{
    internal class Collectable : ICollectable, IPositionable
    {
        public int GetLeft()
        {
            throw new NotImplementedException();
        }

        public int GetTop()
        {
            throw new NotImplementedException();
        }

        public int GetValue()
        {
            throw new NotImplementedException();
        }

        public void PickUp()
        {
            throw new NotImplementedException();
        }
    }
}
