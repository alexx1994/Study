﻿using Study.GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.GameStore.Domain.Abstract
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}