using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture
{
    public interface IPlayer
    {
        public int X { get; set; }

        public int Y { get; set; }
        public void TakeBonus(IBonus bonus);

        public void Move(IGameBoard gameBoard);
    }
}
