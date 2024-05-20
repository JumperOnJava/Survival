using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Engine
{
    public interface IAnimationProvider
    {
        int FrameCount { get; set; }
        int SpriteSize { get; set; }
        int animationOffSet { get; set; }
        float AnimationPlaytime { get; set; }
        float frameTime { get; set; }
        int currentFrame { get; }
        int XPos { get; }
        int YPos { get; }
        void Update();
    }
}