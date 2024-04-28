using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entites
{
    public class Player : Entity
    {
        public Player(int posX, int posY, int runFrames, int idleFrames, int attackFrames, int hitFrames, int deathFrames, int size, int health, Image spriteSheet) 
            : base(posX, posY, runFrames, idleFrames, attackFrames, hitFrames, deathFrames, size, health, spriteSheet)
        {
            currentAnimation = 4;
            currentFrame = 0;
        }

        public bool IntersectsWith(Monster monster)
        {

            if (monster.posX < this.posX + this.size && this.posX < monster.posX + monster.size && monster.posY < this.posY + this.size)
            {
                return this.posY < monster.posY + monster.size;
            }

            return false;
        }

        public override void SetAnimationConfiguration(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch (currentAnimation)
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
