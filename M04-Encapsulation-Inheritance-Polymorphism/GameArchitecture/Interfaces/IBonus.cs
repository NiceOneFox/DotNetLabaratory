﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture
{
    public interface IBonus
    {
        public int Score { get; set; }
        public int GetScore() { return Score; }

    }
}
