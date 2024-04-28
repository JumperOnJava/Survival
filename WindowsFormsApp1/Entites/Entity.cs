using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entites
{
    public abstract class Entity
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public int dirX { get; set; }
        public int dirY { get; set; }
        public bool isMoving { get; set; }
        public int direction;
        public int health;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public int runFrames;
        public int idleFrames;
        public int attackFrames;
        public int hitFrames;
        public int deathFrames;

        public int size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int runFrames, int idleFrames, int attackFrames, int hitFrames, int deathFrames, int size, int health, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.runFrames = runFrames;
            this.idleFrames = idleFrames;
            this.attackFrames = attackFrames;
            this.hitFrames = hitFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            this.size = size;
            currentLimit = idleFrames;
            this.health = health;
        }

        public virtual void Move()
        {
            posX += dirX;
            posY += dirY;
        }

        public virtual void PlayAnimation(Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else currentFrame = 0;
            g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), new Size(size, size)), size * currentFrame, size * currentAnimation, size, size, GraphicsUnit.Pixel);
        }

        public abstract void SetAnimationConfiguration(int currentAnimation);
    }
}
