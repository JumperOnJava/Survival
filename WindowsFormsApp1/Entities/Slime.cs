using Survival.Engine;
using Survival.Entities;
using Survival.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public class Slime : Monster
    {
        public Slime(Vector2 pos) : base(pos, 100, 150, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\slime.png")))
        {
            this.speed = 2;
        }

        public IAnimationProvider currentAnimation = new Animation(1, 1, 1);


        public override void DetermineMonsterAnimation(Player player)
        {
            // Отримати різницю між координатами створіння та гравця
            float dx = player.pos.X - this.pos.X;
            float dy = player.pos.Y - this.pos.Y;

            if (Math.Abs(dx) <= this.currentAnimation.SpriteSize / 4 && Math.Abs(dy) <= this.currentAnimation.SpriteSize / 4)
            {
                //this.SetAnimationConfiguration(currentAnimation.Animation(this.dirStr, "Idle"));
                SetAnimationConfiguration(SlimeAnimations.IDLE_ANIMATION);

            }
            else
            {
                //this.SetAnimationConfiguration(currentAnimation.GetAnimation(this.dirStr, "Run"));
                SetAnimationConfiguration(SlimeAnimations.RUN_ANIMATION);

            }
        }

        public override void UpdateMonsterMovement(Player player)
        {

            float dx = player.pos.X - this.pos.X;
            float dy = player.pos.Y - this.pos.Y;

            int moveX = Math.Sign((int)dx); 
            int moveY = Math.Sign((int)dy);

            // Задати напрямок руху створіння
            Vector2 dir;
            dir.X = moveX;
            dir.Y = moveY;

            // Зберегти напрямок руху монстра
            if (moveX == 0 && moveY == -1)
            {
                //this.direction = 1; // Рух вгору
                this.Direction = Engine.Direction.Up;
            }
            else if (moveX == 0 && moveY == 1)
            {
                //this.direction = 0; // Рух вниз
                this.Direction = Engine.Direction.Down;

            }
            else if ((moveX == 1 && moveY == 0) || (moveX == 1 && moveY == -1) || (moveX == 1 && moveY == 1))
            {
                //this.direction = 2; // Рух вправо
                this.Direction = Engine.Direction.Right;
            }
            else if ((moveX == -1 && moveY == 0) || (moveX == -1 && moveY == -1) || (moveX == -1 && moveY == 1))
            {
                //this.direction = 3; // Рух вліво
                this.Direction = Engine.Direction.Left;

            }

            this.InputMove(dir);
        }

        public void SetAnimationConfiguration(Animation animation)
        {
            currentAnimation = animation;
        }

        public override void Update()
        {
            base.Update();
            currentAnimation.Update();
            UpdateMonsterMovement(scene.player);

            //this.DetermineMonsterAnimation(Form1.player);

        }
    }
}
