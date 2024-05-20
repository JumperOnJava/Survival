using Survival;
using Survival.Engine;
using Survival.Entities;
using Survival.Models;
using Survival.Util;
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
    internal class Ghost : Monster
    {
        public float AttackTimer = 0.5f;
        private float AttackCooldown = 0;

        public Ghost(Vector2 pos) : base(pos, 5, 100, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\ghost.png")))
        {
            new Hitbox(this,15, false);
            
        }
        public void TryAttack(Player player)
        {
            if (Vector2.Distance(this.pos, player.pos) <= 35)
            {
                isAttacking = true;
                player.Hurt(this);
                this.AttackCooldown = 1.5f;
            }
        }
           
        protected override void Update()
        {
            base.Update();

            if (this.hurtTimer > 0)
            {
                isMoving = false;
            }

            if (isAttacking)
            {
                this.AttackTimer -= FormMain.deltaTime;
            }

            if (AttackTimer > 0)
            {
                isAttacking = false;
            }

            this.AttackCooldown -= FormMain.deltaTime;

            if (this.AttackCooldown <= 0)
            {
                this.TryAttack(scene.player);
                speed = 100;
            }
            else speed = 80;

            UpdateMonsterMovement(scene.player);
        }
        
        public override void DetermineMonsterAnimation(Player player)
        {
            if (Vector2.Distance(this.pos, player.pos) >= 400)
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.IDLE_ANIMATIONS, this));
                isMoving = false;
            }
            else if (this.hurtTimer > 0)
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, this));
            }
            else if (AttackTimer > 0 && Vector2.Distance(this.pos, player.pos) <= 35)
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.ATTACK_ANIMATIONS, this));
            }
            else
            {
                this.SetAnimationConfiguration(new AnimationSet(Hero.RUN_ANIMATIONS, this));
            }
        }   

        public override void UpdateMonsterMovement(Player player)
        {
            Vector2 d = player.pos - this.pos;
            if (isMoving)
            {
                this.InputMove(d.Normalized());
            }
           
        }
    }
}
