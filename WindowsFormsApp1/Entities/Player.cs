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
    public class Player : MovingEntity, DamageableEntity
    {
        private float attackTimer = 0.5f;

        private float AttackCooldown = 0;

        protected override Vector2 dir { get => (this.scene.mouseLocation - this.pos).Normalized(); set { } }
        protected RendererComponent renderer;
        public HealthComponent healthComponent;

        public Player(Vector2 pos): base(pos, 200)
        {
            new HitboxEntityComponent(this, 15, false);
            this.healthComponent = HealthComponent.createComponent(this, 5);
            this.renderer = new RendererComponent(this, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\player.png")), new AnimationSet(Hero.IDLE_ANIMATIONS, this));
        }

        public void UpdateAnimation()
        {
            if (isAttacking)
            {
                return;
            }
            attackTimer = 0.5f;

            if (isMoving)
            {
                renderer.SetAnimationConfiguration(new AnimationSet(Hero.RUN_ANIMATIONS, this));
            }
            else
            {
                if (FormMain.PressedKeys[Keys.Space])
                {
                    renderer.SetAnimationConfiguration(new AnimationSet(Hero.ATTACK_ANIMATIONS, this));
                    isAttacking = true;
                    return;
                }
                if (healthComponent.hurtTimer > 0)
                {
                    renderer.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, this));
                }
                else
                {
                    renderer.SetAnimationConfiguration(new AnimationSet(Hero.IDLE_ANIMATIONS, this));
                }
            }
        }

        public void Heal()
        {
            healthComponent.health++;
        }

        protected override void Update()
        {
            base.Update();
            UpdateAnimation();

            

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

            this.AttackCooldown -= FormMain.deltaTime;
            if (FormMain.PressedKeys[Keys.Space] && AttackCooldown <= 0)
            {
                foreach (Entity entity in this.scene.entities)
                {
                    if (entity is HealthComponent healthComponent)
                    {
                        if ((Vector2.Distance(this.pos + this.dir * 30, healthComponent.parent.pos) <= 70) && healthComponent.health > 0)
                        {
                            healthComponent.Hurt(this);
                        }
                    }
                }
                AttackCooldown = 7 / 12f;
            }
        } 
        void DamageableEntity.OnDamage(int currentHealth)
        {
            if (currentHealth <= 0)
            {
                this.scene.GameOver();
            }
        }
    }
}
