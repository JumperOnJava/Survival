using Survival.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Survival.Util;
using Survival.Engine;
using System.Threading;
using System.IdentityModel.Metadata;
using Survival.Controllers;

namespace Survival.Entities
{
    public class Player : AliveEntity
    {
        private Vector2 dir = Vector2.Zero;
        public int numHeart { get; set; }
        public int[] arrHearts { get; } = new int[5] { 1, 1, 1, 1, 1 };
        
        public override float hitboxSize => 32;

        public float attackTimer = 0.5f;

        public Player(Vector2 pos) 
            : base(pos, 100, 200, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\player.png")))
        {
            Radius = 15;
            size = 100;
            this.numHeart = 5;
            new Hitbox(this,(int)Radius);
        }

        public override void Hurt()
        {
            base.Hurt();
            this.numHeart -= 1;
            this.arrHearts[this.numHeart] = 0;
        }

        public override void SetCurrentAnimation()
        {
            if (isAttacking)
            {
                return;
            }
            attackTimer = 0.5f;

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
                    return;
                }
                if (hurtTimer > 0)
                {
                    this.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, this));
                }
                else
                {
                    this.SetAnimationConfiguration(new AnimationSet(Hero.IDLE_ANIMATIONS, this));
                }
            }

        }

        public void PlayerAttack(AliveEntity monster)
        {
            if ((Vector2.Distance(this.pos, monster.pos) <= 50) && monster.health > 0 )
            {
                if (monster is Monster || monster is Tree)
                {
                    monster.isMoving = false;
                    monster.health -= 1;
                    monster.Hurt();
                    //monster.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, monster));
                }
                
            }
        }
        public override void InputMove(Vector2 movement)
        {
            base.InputMove(movement);

            if (movement != Vector2.Zero)
            {
                dir = movement;
            }
        }
        protected override void Update()
        {
            base.Update();
            //Console.WriteLine(this.pos);


            //CheckCollision();

            if (this.numHeart <= 0)
            {
                this.scene.gameOver = true;
            }

            Vector2 playerMovement = new Vector2(
                (Form1.PressedKeys[Keys.D] ? 0 : -1) +
                (Form1.PressedKeys[Keys.A] ? 0 : 1),

                (Form1.PressedKeys[Keys.W] ? 0 : 1) +
                (Form1.PressedKeys[Keys.S] ? 0 : -1)
            );

            this.InputMove(playerMovement.Normalized());
            if (playerMovement != Vector2.Zero)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }


            if (isAttacking)
            {
                this.attackTimer -= Form1.deltaTime;
            }

            if (attackTimer <= 0) 
            { 
                isAttacking = false;
            }

            SetCurrentAnimation();
            
            this.AttackCooldown -= Form1.deltaTime;
            this.UpdateAnimation();
            if (Form1.PressedKeys[Keys.Space] && AttackCooldown <= 0)
            {
                foreach (Entity entity in this.scene.entities) 
                {
                    if (entity is AliveEntity)
                    {
                        PlayerAttack((AliveEntity)entity);
                    }

                    /*
                    if (entity is Tree)
                    {
                        PlayerCutTree((Tree)entity);
                    }   
                    */
                }

                AttackCooldown = 1;
            }

            /*
            this.CutColldown -= Form1.deltaTime;
            if (Form1.PressedKeys[Keys.C] && this.CutColldown <= 0)
            {
                foreach (Entity entity in this.scene.entities)
                {
                    if (entity is Tree)
                    {
                        PlayerCutTree((Tree)entity);
                    }
                }
                this.CutColldown = 2;
            }
            */
            


            if (Form1.PressedKeys[Keys.E])
            {
                if (!this.scene.isShopOpen)
                {
                    this.scene.woodCount++;

                }
            }

        }

        private void UpdateAnimation()
        {
            float angle = (float)(Math.Atan2(dir.Y, dir.X)*(180/Math.PI));

            switch (angle / 90)
            {
                case -1:
                    this.Direction = Engine.Direction.Up;
                    break;
                case 1:
                    this.Direction = Engine.Direction.Down;
                    break;
                case 0.5f:
                case -0.5f:
                case 0:
                    this.Direction = Engine.Direction.Right;
                    break;
                case 1.5f:
                case -1.5f:
                case 2:
                    this.Direction = Engine.Direction.Left;
                    break;
            }
        }
    }
}
