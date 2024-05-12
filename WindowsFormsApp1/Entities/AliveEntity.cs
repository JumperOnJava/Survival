using Survival.Engine;
using Survival.Models;
using Survival.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public abstract class AliveEntity : Entity, DirectionableEntity
    {
        
        public bool isMoving { get; set; }
        public int health;
        public int speed { get; set; }
        public bool isAttacking = false;

        public float AttackCooldown = 0;

        public int damage { get; set; }
        public float hurtTimer = 0;

        public Direction Direction { get; set; }
        
        public IAnimationProvider currentAnimation;
        //public Animation currentAnimation = new Animation(1, 1, 1);

        public float Radius;

        public Image spriteSheet;

        public AliveEntity(Vector2 pos, int health, int speed, Image spriteSheet)
        {
            this.pos = pos;
            this.speed = speed;
            this.health = health;
            this.spriteSheet = spriteSheet;
            currentAnimation = new AnimationSet(Hero.RUN_ANIMATIONS, this);
        }

        public virtual void InputMove(Vector2 movement)
        {
            isMoving = movement.Length() != 0;
            pos += movement * Form1.deltaTime * speed;
        }


        public void CheckCollision()
        {
            foreach (var entity in this.scene.entities)
            {
                if (entity == this)
                { 
                    continue; 
                }
                if(!(entity is AliveEntity))
                {
                    continue;
                }

                AliveEntity entity2 = (AliveEntity)entity;

                if (Vector2.Distance(this.pos, entity.pos) < this.Radius + entity2.Radius)
                {
                    Vector2 mid = (this.pos + entity.pos) / 2;
                    Vector2 O1 = this.pos - mid;
                    Vector2 O2 = entity.pos - mid;
                    O1 = O1.Normalized();
                    O2 = O2.Normalized();
                    this.pos = mid + O1 * this.Radius;
                    entity.pos = mid + O2 * entity2.Radius;
                }

            }
        }


        public override void Draw(Graphics g)
        {

            var rect = new Rectangle(new Point((int)pos.X, (int)pos.Y), new Size(currentAnimation.SpriteSize, currentAnimation.SpriteSize));
            g.DrawImage(spriteSheet, rect, currentAnimation.XPos, currentAnimation.YPos, currentAnimation.SpriteSize, currentAnimation.SpriteSize, GraphicsUnit.Pixel);
        }

        public bool IntersectsWith(Entity entity)
        {
            if (this != null
                && entity.pos.X < this.pos.X + this.hitboxSize
                && this.pos.X < entity.pos.X + entity.hitboxSize
                && entity.pos.Y < this.pos.Y + this.hitboxSize
                && this.pos.Y < entity.pos.Y + entity.hitboxSize)
            {
                return true;
            }

            return false;
        }

        public virtual void SetAnimationConfiguration(IAnimationProvider animation)
        {
            currentAnimation = animation;
        }

        public virtual void SetCurrentAnimation() { }

        public virtual void Hurt()
        {
            //damage = 10;
            hurtTimer = 4 / 6f;

        }


        // Method to apply knockback to the entity
        public void ApplyKnockback(Vector2 knockback)
        {
            pos -= knockback;
        }

        // Method to handle taking damage and knockback
        public void TakeDamageAndKnockback(int damage, Vector2 attackerPosition)
        {
            health -= damage;
            Vector2 knockback = CalculateKnockbackVector(attackerPosition);
            ApplyKnockback(knockback);
            //Hurt(); // Trigger any additional hurt-related effects (e.g., animations)
        }

        // Method to calculate knockback vector
        public Vector2 CalculateKnockbackVector(Vector2 attackerPosition)
        {
            Vector2 direction = Vector2.Normalize(pos - attackerPosition);
            float knockbackForce = 40; // Adjust as needed
            return direction * knockbackForce;
        }



        public override void Update()
        {
            currentAnimation.Update();

            if(hurtTimer > 0)
                this.hurtTimer -= Form1.deltaTime;
            CheckCollision();
        }
    }
}
