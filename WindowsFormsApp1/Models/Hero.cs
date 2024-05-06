using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Survival.Engine;
using Survival.Entities;

namespace Survival.Models
{
    public static class Hero
    {
        public static Animation RUN_ANIMATION_UP =     new Animation(6, 128, 1, 1 / 6f);
        public static Animation RUN_ANIMATION_DOWN =   new Animation(6, 128, 0, 1 / 6f);
        public static Animation RUN_ANIMATION_RIGHT =  new Animation(6, 128, 2, 1 / 6f);
        public static Animation RUN_ANIMATION_LEFT =   new Animation(6, 128, 3, 1 / 6f);

        public static Animation IDLE_ANIMATION_UP =    new Animation(12, 128, 5, 1 / 6f);
        public static Animation IDLE_ANIMATION_DOWN =  new Animation(12, 128, 4, 1 / 6f);
        public static Animation IDLE_ANIMATION_RIGHT = new Animation(12, 128, 6, 1 / 6f);
        public static Animation IDLE_ANIMATION_LEFT =  new Animation(12, 128, 7, 1 / 6f);

        public static Animation ATTACK_ANIMATION_UP =  new Animation(7, 128, 9, 1 / 12f);
        public static Animation ATTACK_ANIMATION_DOWN =new Animation(7, 128, 8, 1 / 12f);
        public static Animation ATTACK_ANIMATION_RIGHT=new Animation(7, 128, 11, 1 / 12f);
        public static Animation ATTACK_ANIMATION_LEFT =new Animation(7, 128, 10, 1 / 12f);

        public static Animation HIT_ANIMATION_UP =     new Animation(4, 128, 13, 1 / 6f);
        public static Animation HIT_ANIMATION_DOWN =   new Animation(4, 128, 12, 1 / 6f);
        public static Animation HIT_ANIMATION_RIGHT=   new Animation(4, 128, 14, 1 / 6f);
        public static Animation HIT_ANIMATION_LEFT =   new Animation(4, 128, 15, 1 / 6f);

        public static Animation DEATH_ANIMATION =      new Animation(8, 128, 16, 1 / 6f);

        public static Dictionary<Direction, IAnimationProvider> RUN_ANIMATIONS = new Dictionary<Direction, IAnimationProvider>()
        {
            { Direction.Up, RUN_ANIMATION_UP },
            { Direction.Down, RUN_ANIMATION_DOWN },
            { Direction.Right, RUN_ANIMATION_RIGHT },
            { Direction.Left, RUN_ANIMATION_LEFT },
        };

        public static Dictionary<Direction, IAnimationProvider> IDLE_ANIMATIONS = new Dictionary<Direction, IAnimationProvider>()
        {
            { Direction.Up, IDLE_ANIMATION_UP },
            { Direction.Down, IDLE_ANIMATION_DOWN },
            { Direction.Right, IDLE_ANIMATION_RIGHT },
            { Direction.Left, IDLE_ANIMATION_LEFT },
        };

        public static Dictionary<Direction, IAnimationProvider> ATTACK_ANIMATIONS = new Dictionary<Direction, IAnimationProvider>()
        {
            { Direction.Up,    ATTACK_ANIMATION_UP },
            { Direction.Down,  ATTACK_ANIMATION_DOWN },
            { Direction.Right, ATTACK_ANIMATION_RIGHT },
            { Direction.Left,  ATTACK_ANIMATION_LEFT },
        };

        public static Dictionary<Direction, IAnimationProvider> HIT_ANIMATIONS = new Dictionary<Direction, IAnimationProvider>()
        {
            { Direction.Up,    HIT_ANIMATION_UP },
            { Direction.Down,  HIT_ANIMATION_DOWN },
            { Direction.Right, HIT_ANIMATION_RIGHT },
            { Direction.Left,  HIT_ANIMATION_LEFT },
        };
    }
}
