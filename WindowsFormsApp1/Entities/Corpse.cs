using Survival.Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public class Corpse : Entity
    {

        private float timeLeft = 5;

        public Corpse(Image sprite, IAnimationProvider deathAnimation) : base(null)
        {
            new RendererComponent(this, sprite, deathAnimation);
        }

        protected override void Update()
        {
            timeLeft -= FormMain.deltaTime;
            
            if (timeLeft < 0)
            {
                RemoveEntity();
            }         
        }

        public override void Draw(Graphics g)
        {
            //var rect = new Rectangle(new Point((int)monster.pos.X - monster.currentAnimation.SpriteSize / 2, (int)monster.pos.Y - monster.currentAnimation.SpriteSize / 2), new Size(monster.currentAnimation.SpriteSize, monster.currentAnimation.SpriteSize));
            //g.DrawImage(monster.spriteSheet, rect, monster.currentAnimation.SpriteSize * 7, monster.currentAnimation.SpriteSize * 16, monster.currentAnimation.SpriteSize, monster.currentAnimation.SpriteSize, GraphicsUnit.Pixel);
            
        }
    }

    internal class StaticAnimation : IAnimationProvider
    {
        public int SpriteSize { get ; private set; }

        public int XPos { get; private set; }

        public int YPos { get; private set; }

        public void Update()
        {
        }

        public StaticAnimation(int spriteSize, int xpos, int ypos)
        {
            SpriteSize = spriteSize;
            XPos = xpos * spriteSize;
            YPos = ypos * spriteSize;
        }
    }
}
