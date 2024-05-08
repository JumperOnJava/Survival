using Survival.Engine;
using Survival.Models;
using Survival.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

        public int damage { get; set; }
        public float hurtTimer = 0;

        public Direction Direction { get; set; }
        
        public IAnimationProvider currentAnimation;
        //public Animation currentAnimation = new Animation(1, 1, 1);

        public float R1 = 20;
        public float R2 = 20;

        public Image spriteSheet;

        public AliveEntity(Vector2 pos, int health, int speed, Image spriteSheet)
        {
            this.pos = pos;
            this.speed = speed;
            this.health = health;
            this.spriteSheet = spriteSheet;
            currentAnimation = new AnimationSet(Hero.RUN_ANIMATIONS, this);
        }



        /*
        public virtual void InputMove(Vector2 movement)
        {
            isMoving = movement.Length() != 0;

            Vector2 newPosition = pos + movement * Form1.deltaTime * speed;

            // Перевірка зіткнення з новою позицією
            if (!CheckCollision(newPosition))
            {
                pos = newPosition; // Перемістимо ентіті, якщо немає зіткнення
            }
        }
        */

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

                if (Vector2.Distance(this.pos, entity.pos) < R1 + R2)
                {
                    Vector2 mid = (this.pos + entity.pos) / 2;
                    Vector2 O1 = this.pos - mid;
                    Vector2 O2 = entity.pos - mid;
                    O1 = O1.Normalized();
                    O2 = O2.Normalized();
                    this.pos = (mid + O1) * -0.8f;
                    entity.pos = (mid + O2) * 0.81f;
                }



            }




            /*
            // Перевірка зіткнень з іншими ентіті
            foreach (var entity in this.scene.entities)
            {
                // Пропускаємо перевірку самого себе
                if (entity == this)
                    continue;
                var rect = new RectangleF(0, 0, 20, 20);
                rect.IntersectsWith()

                
                if (newPos.X < entity.pos.X + entity.hitboxSize &&
                    newPos.X + hitboxSize > entity.pos.X &&
                    newPos.Y < entity.pos.Y + entity.hitboxSize &&
                    newPos.Y + hitboxSize > entity.pos.Y)
                {
                    // Якщо є зіткнення, повертаємо true
                    return true;
                }
                

            }
            // Якщо зіткнень не виявлено, повертаємо false
            return false;
            */
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
            damage = 10;
            hurtTimer = 4 / 6f;

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
