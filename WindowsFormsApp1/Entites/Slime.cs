using Survival.Entites;
using Survival.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entites
{
    public class Slime : Monster
    {
        public Slime(int posX, int posY, int runFrames, int idleFrames, int attackFrames, int hitFrames, int deathFrames, int size, int health, Image spriteSheet) : base(posX, posY, runFrames, idleFrames, attackFrames, hitFrames, deathFrames, size, health, spriteSheet)
        {
            this.currentAnimation = 0;
            this.isDead = false;
            this.speed = 2;
        }

        /*
        public Rectangle GetBoundingBox()
        {
            // Отримати розміри сліму
            int slimeWidth = spriteSheet.Width / SlimeMonster.idleFrames;
            int slimeHeight = spriteSheet.Height;

            // Створити прямокутник, що обмежує область, де зображується слім
            Rectangle boundingBox = new Rectangle(this.posX, this.posY, slimeWidth, slimeHeight);

            return boundingBox;
        }
        */

        public override bool IntersectsWith(Player player)
        {
            if (player.posX + 64 < this.posX + this.size && this.posX < player.posX + player.size - 64 && player.posY + 64 < this.posY + this.size)
            {
                return this.posY < player.posY + player.size - 64;
            }

            return false;
        }


        public override void UpdateMonsterMovement(Player player)
        {

            int dx = (player.posX + 40) - this.posX;
            int dy = (player.posY + 40) - this.posY;

            // Визначити напрямок руху створіння
            int moveX = Math.Sign(dx); // Рухатись в напрямку гравця по осі X
            int moveY = Math.Sign(dy); // Рухатись в напрямку гравця по осі Y

            // Задати напрямок руху створіння
            this.dirX = moveX;
            this.dirY = moveY;

            // Зберегти напрямок руху монстра
            if (moveX == 0 && moveY == -1)
            {
                this.direction = 1; // Рух вгору
            }
            else if (moveX == 0 && moveY == 1)
            {
                this.direction = 0; // Рух вниз
            }
            else if (moveX == 1 && moveY == 0)
            {
                this.direction = 2; // Рух вправо
            }
            else if (moveX == -1 && moveY == 0)
            {
                this.direction = 3; // Рух вліво
            }

            if (!this.IntersectsWith(player))
            {
                this.Move();
            }

        }

        public override void DetermineMonsterAnimation(Player player)
        {
            // Отримати різницю між координатами створіння та гравця
            int dx = player.posX - this.posX;
            int dy = player.posY - this.posY;
            if (this.IntersectsWith(player))
            {
                this.SetAnimationConfiguration(0);
            }
            else
            {
                // Визначити напрямок руху створіння
                if (dx == 0 && dy < 0)
                {
                    this.SetAnimationConfiguration(2); // Рух вверх
                }
                else if (dx > 0 && dy < 0)
                {
                    this.SetAnimationConfiguration(2); // Рух по діагоналі вправо вгору
                }
                else if (dx > 0 && dy == 0)
                {
                    this.SetAnimationConfiguration(2); // Рух вправо
                }
                else if (dx > 0 && dy > 0)
                {
                    this.SetAnimationConfiguration(2); // Рух по діагоналі вправо вниз
                }
                else if (dx == 0 && dy > 0)
                {
                    this.SetAnimationConfiguration(2); // Рух вниз
                }
                else if (dx < 0 && dy > 0)
                {
                    this.SetAnimationConfiguration(2); // Рух по діагоналі вліво вниз (той самий що й вниз)
                }
                else if (dx < 0 && dy == 0)
                {
                    this.SetAnimationConfiguration(2); // Рух вліво
                }
                else if (dx < 0 && dy < 0)
                {
                    this.SetAnimationConfiguration(2); // Рух по діагоналі вліво вгору (той самий що й вгору)
                }
            }
        }


        public override void SetAnimationConfiguration(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch (currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 2:
                    currentLimit = runFrames;
                    break;
                case 1:
                    currentLimit = attackFrames;
                    break;
                case 3:
                    currentLimit = hitFrames;
                    break;
                case 4:
                    currentLimit = deathFrames;
                    break;
            }
        }

    }
}
