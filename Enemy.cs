using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Enemy : IPositionable, IUpdatable
    {
        public int GetLeft()
        {
            throw new NotImplementedException();
        }

        public int GetTop()
        {
            throw new NotImplementedException();
        }

        public void Update(TimeSpan deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}
