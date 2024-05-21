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
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Survival.Entities
{
    public class Player : AliveEntity
    {
        private float attackTimer = 0.5f;

        private float AttackCooldown = 0;

        protected override Vector2 dir { get => (this.scene.mouseLocation - this.pos).Normalized(); set { } }
        public Player(Vector2 pos)
            : base(pos, 100, 200, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\player.png")))
        {
            this.health = 5;
            new Hitbox(this, 15, false);
        }

        public override void Hurt(Entity attacker)
        {
            base.Hurt(attacker);
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
                if (FormMain.PressedKeys[Keys.Space])
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
            if ((Vector2.Distance(this.pos+this.dir*30, monster.pos) <= 70) && monster.health > 0)
            {
                if (monster is AliveEntity)
                {         
                    monster.Hurt(this);
                }
            }
        }

        public void Heal()
        {
            this.health++;
        }
        public override void InputMove(Vector2 movement)
        {
            base.InputMove(movement);
        }
        protected override void Update()
        {
            base.Update();

            if (this.health <= 0)
            {
                this.scene.GameOver();
            }

            Vector2 playerMovement = new Vector2(
                (FormMain.PressedKeys[Keys.D] ? 0 : -1) +
                (FormMain.PressedKeys[Keys.A] ? 0 : 1),

                (FormMain.PressedKeys[Keys.W] ? 0 : 1) +
                (FormMain.PressedKeys[Keys.S] ? 0 : -1)
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
                this.attackTimer -= FormMain.deltaTime;
            }

            if (attackTimer <= 0)
            {
                isAttacking = false;
            }

            SetCurrentAnimation();

            this.AttackCooldown -= FormMain.deltaTime;
            if (FormMain.PressedKeys[Keys.Space] && AttackCooldown <= 0)
            {
                foreach (Entity entity in this.scene.entities)
                {
                    if (entity is AliveEntity)
                    {
                        PlayerAttack((AliveEntity)entity);
                    }
                }
                AttackCooldown = 7 / 12f;
            }
        } 
    }
}
