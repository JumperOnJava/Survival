using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Survival.Entities;
using Survival.Engine;

namespace Survival.Models
{
    public static class SlimeAnimations
    {
        public static Animation RUN_ANIMATION = new Animation(7, 64, 2);
        public static Animation IDLE_ANIMATION = new Animation(7, 64, 2);
        public static Animation ATTACK_ANIMATION = new Animation(7, 64, 2);
        public static Animation HIT_ANIMATION = new Animation(7, 64, 2);
        public static Animation DEATH_ANIMATION = new Animation(7, 64, 2);
    }
}
