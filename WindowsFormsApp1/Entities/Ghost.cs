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
using static System.Net.Mime.MediaTypeNames;

namespace Survival.Entities
{
    internal class Ghost : MovingEntity, DamageableEntity
    {
        public float AttackTimer = 0.5f;
        private float AttackCooldown = 0;

        private RendererComponent renderer;
        private HealthComponent healthComponent;

        public Ghost(Vector2 pos) : base(pos, 100)
        {
            new HitboxEntityComponent(this, 15, false);
            this.healthComponent = HealthComponent.createComponent(this, 5);
            this.renderer = new RendererComponent(this, Sprites.Ghost, new AnimationSet(Hero.IDLE_ANIMATIONS, this));
        }
        public void TryAttack(Player player)
        {
            if (Vector2.Distance(this.pos, player.pos) <= 35)
            {
                isAttacking = true;
                player.healthComponent.Hurt(this);
                this.AttackCooldown = 1.5f;
            }
        }

        protected override void Update()
        {
            base.Update();

            this.isMoving = true;
            this.DetermineMonsterAnimation(scene.player);

            if (healthComponent.hurtTimer > 0)
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

        public void DetermineMonsterAnimation(Player player)
        {
            if (Vector2.Distance(this.pos, player.pos) >= 400)
            {
                renderer.SetAnimationConfiguration(new AnimationSet(Hero.IDLE_ANIMATIONS, this));
                isMoving = false;
            }
            else if (healthComponent.hurtTimer > 0)
            {
                renderer.SetAnimationConfiguration(new AnimationSet(Hero.HIT_ANIMATIONS, this));
            }
            else if (AttackTimer > 0 && Vector2.Distance(this.pos, player.pos) <= 35)
            {
                renderer.SetAnimationConfiguration(new AnimationSet(Hero.ATTACK_ANIMATIONS, this));
            }
            else
            {
                renderer.SetAnimationConfiguration(new AnimationSet(Hero.RUN_ANIMATIONS, this));
            }
        }

        public void UpdateMonsterMovement(Player player)
        {
            Vector2 d = player.pos - this.pos;
            if (isMoving)
            {
                this.InputMove(d.Normalized());
            }
        }
        void DamageableEntity.OnDamage(int currentHealth)
        {
            if(currentHealth <= 0)
            {
                this.scene.IncrementScore();
                this.RemoveEntity();
                this.scene.AddEntities(new Corpse(Sprites.Ghost, new StaticAnimation(128, 7, 16)));
            }
        }
    }
}
