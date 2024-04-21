using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entites
{
    public class Entity
    {
        public int posX;
        public int posY;

        public int dirX;
        public int dirY;
        public bool isMoving;

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

        public Entity(int posX, int posY, int runFrames, int idleFrames, int attackFrames, int hitFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.runFrames = runFrames;
            this.idleFrames = idleFrames;
            this.attackFrames = attackFrames;
            this.hitFrames = hitFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            size = 128;
            currentAnimation = 4;
            currentFrame = 0;
            currentLimit = idleFrames;
        }

        public void Move()
        {
            posX += dirX;
            posY += dirY;
        }

        public void PlayAnimation(Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else currentFrame = 0;
            g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), new Size(size, size)), 128 * currentFrame, 128 * currentAnimation, size, size, GraphicsUnit.Pixel);
        }

        public void SetAnimationConfiguration(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch(currentAnimation)
            {
                case 4:
                case 5:
                case 6:
                case 7:
                    currentLimit = idleFrames;
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                    currentLimit = runFrames;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                    currentLimit = attackFrames;
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                    currentLimit = hitFrames;
                    break;
                case 16:
                    currentLimit = deathFrames;
                    break;
            }
        }

    }
}
