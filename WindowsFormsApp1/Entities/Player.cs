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

namespace Survival.Entities
{
    public class Player : AliveEntity
    {
        public int countKill { get; set; }
        public Vector2 dir = Vector2.Zero;
       
        public override float hitboxSize => 32;

        public float AttackCooldown = 0;
        public Player(Vector2 pos) 
            : base(pos, 100, 200, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\player.png")))
        {
            countKill = 0;
        }
        
        

        public void PlayerAttack(AliveEntity monster)
        {
            if (this.IntersectsWith(monster) && monster.health > 0)
            {
                monster.isMoving = false;
                monster.health -= 50;
                monster.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, this));

            }
        }

        
        public override void InputMove(Vector2 movement)
        {
            base.InputMove(movement);
            if (movement != Vector2.Zero)
            {
                dir = movement;
                this.SetAnimationConfiguration(new AnimationSet(Hero.RUN_ANIMATIONS, this));
            }
            else
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.IDLE_ANIMATIONS, this));
            }
        }
        public override void Update()
        {
            base.Update();

            if (this.health < 0)
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
            this.AttackCooldown -= Form1.deltaTime;
            this.UpdateAnimation();
            if (Form1.PressedKeys[Keys.Space] && AttackCooldown <= 0)
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.ATTACK_ANIMATIONS, this));
                foreach (Entity entity in this.scene.entities) 
                {
                    if (entity is AliveEntity)
                    {
                        PlayerAttack((AliveEntity)entity);
                    }

                }
                AttackCooldown = 1;
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
