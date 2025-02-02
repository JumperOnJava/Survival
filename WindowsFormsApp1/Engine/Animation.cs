using Survival;
using Survival.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Engine
{
    public class Animation : IAnimationProvider
    {
        public int FrameCount { get; set; }
        public int SpriteSize { get; set; }
        public int animationOffset { get; set; }
        public float AnimationPlaytime { get; set; }
        public float frameTime { get; set; }
        public int currentFrame => (int)(AnimationPlaytime / frameTime);
        public int XPos => SpriteSize * currentFrame;
        public int YPos => SpriteSize * animationOffset;

        public Animation(int frameCount, int SpriteSize, int animationOffset) : this(frameCount, SpriteSize, animationOffset, 1 / 12f)
        {
        }

        public Animation(int frameCount, int SpriteSize, int animationOfSet, float frameTime)
        {
            this.FrameCount = frameCount;
            this.SpriteSize = SpriteSize;
            this.animationOffset = animationOfSet;
            this.frameTime = frameTime;
        }

        public void Update()
        {
            if (this.currentFrame < this.FrameCount - 1)
            {
                this.AnimationPlaytime += FormMain.deltaTime;
            }
            else
            {
                this.AnimationPlaytime = 0;
            }
        }
    }
}
