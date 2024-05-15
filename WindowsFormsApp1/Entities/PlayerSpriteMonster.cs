using Survival;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival.Entities
{
    internal class PlayerSpriteMonster : Monster
    {
        public float Attacktimer = 0.5f;
        public override float hitboxSize => 32;

        public PlayerSpriteMonster(Vector2 pos) : base(pos, 5, 100, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\player.png")))
        {
            Radius = 30;
            new Hitbox(this,(int)Radius);

        }
        public void TryAttack(Player player)
        {
            if (this.IntersectsWith(player))
            {
                isAttacking = true;
                player.Hurt();
                this.SetAnimationConfiguration(new AnimationSet(Hero.ATTACK_ANIMATIONS, this));

                Vector2 knockback = CalculateKnockbackVector(player.pos);
                //player.ApplyKnockback(knockback);

                this.AttackCooldown = 1.5f;
                //this.SetAnimationConfiguration(new AnimationSet(Hero.ATTACK_ANIMATIONS, this));

            }
        }
           
        protected override void Update()
        {
            base.Update();
            //UpdateMonsterMovement(scene.player);


            if (this.hurtTimer > 0)
            {
                isMoving = false;
            }

            if (isAttacking)
            {
                this.Attacktimer -= Form1.deltaTime;
            }

            if (Attacktimer <= 0)
            {
                isAttacking = false;
            }

            this.AttackCooldown -= Form1.deltaTime;

            if (this.AttackCooldown <= 0)
            {
                this.TryAttack(scene.player);              
            }

            UpdateMonsterMovement(scene.player);

        }
        public override void DetermineMonsterAnimation(Player player)
        {
            // Отримати різницю між координатами створіння та гравця
            float dx = player.pos.X - this.pos.X;
            float dy = player.pos.Y - this.pos.Y;
            if (Math.Abs(dx) <= this.currentAnimation.SpriteSize / 4 && Math.Abs(dy) <= this.currentAnimation.SpriteSize / 4)
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.IDLE_ANIMATIONS, this));
            }
            else if (this.hurtTimer > 0)
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, this));
            }
            else
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.RUN_ANIMATIONS, this));
            }
        }

        /*
        public override void SetCurrentAnimation()
        {
            if (isAttacking)
            {
                return;
            }
            //Attacktimer = 0.5f;

            if (isMoving)
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.RUN_ANIMATIONS, this));
            }
            else
            {
                
                if (Form1.PressedKeys[Keys.Space])
                {
                    this.SetAnimationConfiguration(new AnimationSet(Hero.ATTACK_ANIMATIONS, this));
                    isAttacking = true;
                }
                if (this.hurtTimer > 0)
                {
                    this.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, this));
                }
                else
                {
                    this.SetAnimationConfiguration(new AnimationSet(Hero.IDLE_ANIMATIONS, this));
                }
            }

        }
        */
        

        public override void UpdateMonsterMovement(Player player)
        {

            float dx = player.pos.X - this.pos.X;
            float dy = player.pos.Y - this.pos.Y;

            int moveX = Math.Sign((int)dx); // Рухатись в напрямку гравця по осі X
            int moveY = Math.Sign((int)dy); // Рухатись в напрямку гравця по осі Y

            Vector2 dir;
            dir.X = moveX;
            dir.Y = moveY;

            // Зберегти напрямок руху монстра
            if (moveX == 0 && moveY == -1)
            {
                this.Direction = Engine.Direction.Up;
            }
            else if (moveX == 0 && moveY == 1)
            {
                this.Direction = Engine.Direction.Down;
            }
            else if ((moveX == 1 && moveY == 0) || (moveX == 1 && moveY == -1) || (moveX == 1 && moveY == 1))
            {
                this.Direction = Engine.Direction.Right;
            }
            else if ((moveX == -1 && moveY == 0) || (moveX == -1 && moveY == -1) || (moveX == -1 && moveY == 1))
            {
                this.Direction = Engine.Direction.Left;
            }

            if (isMoving)
            {
                this.InputMove(dir);
            }
           
        }
    }
}
