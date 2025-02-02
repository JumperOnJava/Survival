using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Engine
{
    public interface IAnimationProvider
    {
        int SpriteSize { get; }
        int XPos { get; }
        int YPos { get; }
        void Update();
    }
}