using Survival.Entities;
using Survival.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Engine
{
    public class AnimationSet : IAnimationProvider
    {
        public IAnimationProvider currentAnimation => Animations[target.Direction];
        private DirectionableEntity target;

        public string Dir {  get; set; }
        public int FrameCount { get => currentAnimation.FrameCount; set => currentAnimation.FrameCount = value; }
        public int SpriteSize { get => currentAnimation.SpriteSize; set => currentAnimation.SpriteSize = value; }
        public int animationOffSet { get => currentAnimation.animationOffSet; set => currentAnimation.animationOffSet = value; }
        public float AnimationPlaytime { get => currentAnimation.AnimationPlaytime; set => currentAnimation.AnimationPlaytime = value; }
        public float frameTime { get => currentAnimation.frameTime; set => currentAnimation.frameTime = value; }

        public int currentFrame => currentAnimation.currentFrame;

        public int XPos => currentAnimation.XPos;

        public int YPos => currentAnimation.YPos;

        public IDictionary<Direction, IAnimationProvider> Animations { get; }

        public AnimationSet(IDictionary<Direction,IAnimationProvider> animations,DirectionableEntity entity)
        {
            Animations = animations;
            this.target = entity;
            Update();
        }

        public void Update()
        {
            currentAnimation.Update();
        }
    }

    public interface DirectionableEntity
    {
        Direction Direction { get; }
    }
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    }
}
