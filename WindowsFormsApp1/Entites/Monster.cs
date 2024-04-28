using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Survival.Entites
{
    public class Monster : Entity
    {
        public bool isDead;
        public int speed;
        public Monster(int posX, int posY, int runFrames, int idleFrames, int attackFrames, int hitFrames, int deathFrames, int size, int health, Image spriteSheet) : base(posX, posY, runFrames, idleFrames, attackFrames, hitFrames, deathFrames, size, health, spriteSheet)
        {
            this.isDead = false;
            this.speed = 1;
        }

        public virtual bool IntersectsWith(Player player)
        {
            if (player.posX < this.posX + this.size / 4 && this.posX < player.posX + player.size / 4 && player.posY < this.posY + this.size / 4)
            {
                return this.posY < player.posY + player.size / 4;
            }
            
            return false;
        }

        public void MonsterAttack(Player player)
        {
            if (this.IntersectsWith(player) && !this.isDead)
            {
                player.health -= 1;

                switch (player.direction)
                {
                    case 0:
                        player.SetAnimationConfiguration(13);
                        break;
                    case 1:
                        player.SetAnimationConfiguration(12);
                        break;
                    case 2:
                        player.SetAnimationConfiguration(14);
                        break;
                    case 3:
                        player.SetAnimationConfiguration(15);
                        break;
                }
            }
        }

        public override void Move()
        {
            // Множимо швидкість на напрямок для отримання кроків руху
            posX += dirX * speed;
            posY += dirY * speed;
        }

        public virtual void UpdateMonsterMovement(Player player)
        {

            int dx = player.posX - this.posX;
            int dy = player.posY - this.posY;

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

            if (Math.Abs(dx) <= this.size / 4 && Math.Abs(dy) <= this.size / 4)
            {
                this.dirX = 0;
                this.dirY = 0;
            }
            else
            {
                this.Move();
            }
        }

        public virtual void DetermineMonsterAnimation(Player player)
        {
            // Отримати різницю між координатами створіння та гравця
            int dx = player.posX - this.posX;
            int dy = player.posY - this.posY;
            if (Math.Abs(dx) <= this.size / 4 && Math.Abs(dy) <= this.size / 4)
            {
                switch (this.direction)
                {
                    case 0:
                        this.SetAnimationConfiguration(4);
                        break;
                    case 1:
                        this.SetAnimationConfiguration(5);
                        break;
                    case 2:
                        this.SetAnimationConfiguration(6);
                        break;
                    case 3:
                        this.SetAnimationConfiguration(7);
                        break;
                }
            }
            else
            {
                // Визначити напрямок руху створіння
                if (dx == 0 && dy < 0)
                {
                    this.SetAnimationConfiguration(1); // Рух вверх
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
                    this.SetAnimationConfiguration(0); // Рух вниз
                }
                else if (dx < 0 && dy > 0)
                {
                    this.SetAnimationConfiguration(3); // Рух по діагоналі вліво вниз (той самий що й вниз)
                }
                else if (dx < 0 && dy == 0)
                {
                    this.SetAnimationConfiguration(3); // Рух вліво
                }
                else if (dx < 0 && dy < 0)
                {
                    this.SetAnimationConfiguration(3); // Рух по діагоналі вліво вгору (той самий що й вгору)
                }
            }
        }

        public override void PlayAnimation(Graphics g)
        {
            if (!isDead)
            {
                if (currentFrame < currentLimit - 1)
                    currentFrame++;
                else
                {
                    if (currentAnimation == 16)
                        isDead = true;
                    else
                        currentFrame = 0;
                }
            }
            g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), new Size(size, size)), size * currentFrame, size * currentAnimation, size, size, GraphicsUnit.Pixel);

           
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

        /*
        private void AutoMoving(Entity player)
        {
            // Перевірка чи монстр досягнув гравця
            if (Math.Abs(this.posX - player.posX) <= this.size / 4 && Math.Abs(this.posY - player.posY) <= this.size / 4)
            {
                this.dirX = 0;
                this.dirY = 0;
                switch (this.direction)
                {
                    case 0:
                        this.SetAnimationConfiguration(4);
                        break;
                    case 1:
                        this.SetAnimationConfiguration(5);
                        break;
                    case 2:
                        this.SetAnimationConfiguration(6);
                        break;
                    case 3:
                        this.SetAnimationConfiguration(7);
                        break;
                }
            }
            else
            {
                if (this.posX > player.posX)
                {
                    this.dirX = -3;
                    this.direction = 3;
                }
                else if (this.posX < player.posX)
                {
                    this.dirX = 3;
                    this.direction = 2;
                }
                else
                {
                    this.dirX = 0;
                }

                if (this.posY > player.posY)
                {
                    this.dirY = -3;
                    this.direction = 1;
                }
                else if (this.posY < player.posY)
                {
                    this.dirY = 3;
                    this.direction = 0;
                }
                else
                {
                    this.dirY = 0;
                }

                if (this.dirX != 0 && this.dirY != 0)
                {
                    this.dirX = (int)(this.dirX * this.speed);
                    this.dirY = (int)(this.dirY * this.speed);
                }

                if (this.dirX == 0 || this.dirY == 0) // перевірка на рух по осі
                {
                    this.dirX = 0;
                    this.dirY = 0;
                }

                if (this.dirX != 0 || this.dirY != 0)
                {
                    this.Move();
                }
            }
        }

        private void AutoMovingAnim(Monster monster)
        {
            if (this.dirY == 0 && this.direction == 3)
            {
                this.SetAnimationConfiguration(3);
            }
            else if (this.dirY == 0 && this.direction == 2)
            {
                this.SetAnimationConfiguration(2);
            }
            else if (this.direction == 0)
            {
                this.SetAnimationConfiguration(0);
            }
            else { this.SetAnimationConfiguration(1); }

        }
        */

    }
}
