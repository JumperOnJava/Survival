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
using System.Threading;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public abstract class AliveEntity : Entity, DirectionableEntity
    {      
        protected bool isMoving { get; set; }
        public int health { get; protected set; }
        public int speed { get; set; }
        protected bool isAttacking = false;
        public float hurtTimer {  get; set; }
        protected virtual Vector2 dir { get; set; } = Vector2.Zero;

        public Direction Direction
        {
            get
            {
                float angle = (float)(Math.Atan2(dir.Y, dir.X) * (180 / Math.PI));
                angle = (angle + 360) % 360;

                if (angle > 45 && angle < 135)
                    return Engine.Direction.Down;
                else if (angle >= 135 && angle <= 225)
                    return Engine.Direction.Left;
                else if (angle > 225 && angle < 315)
                    return Engine.Direction.Up;
                else
                    return Engine.Direction.Right;
            }
        }

        public IAnimationProvider currentAnimation { get; private set; }


        public Image spriteSheet { get; }

        public AliveEntity(Vector2 pos, int health, int speed, Image spriteSheet) : base(null)
        {
            this.pos = pos;
            this.speed = speed;
            this.health = health;
            this.spriteSheet = spriteSheet;
            currentAnimation = new AnimationSet(Hero.IDLE_ANIMATIONS, this);
            hurtTimer = 0;
        }

        public AliveEntity(Vector2 pos, Image spriteSheet) : base(null)
        {
            this.pos = pos;
            this.spriteSheet = spriteSheet;
        }

        public virtual void InputMove(Vector2 movement)
        {
            if (movement != Vector2.Zero)
            {
                dir = movement;
            }
            isMoving = movement.Length() != 0;
            pos += movement * FormMain.deltaTime * speed;
        }

        public override void Draw(Graphics g)
        {

            var rect = new Rectangle(new Point((int)pos.X - currentAnimation.SpriteSize / 2, (int)pos.Y - currentAnimation.SpriteSize / 2), new Size(currentAnimation.SpriteSize, currentAnimation.SpriteSize));
            g.DrawImage(spriteSheet, rect, currentAnimation.XPos, currentAnimation.YPos, currentAnimation.SpriteSize, currentAnimation.SpriteSize, GraphicsUnit.Pixel);
        }

        public virtual void SetAnimationConfiguration(IAnimationProvider animation)
        {
            currentAnimation = animation;
        }

        public virtual void SetCurrentAnimation() { }

        public virtual void Hurt(Entity attacker)
        {
            if (attacker == this)
                return;
            this.isMoving = false;

            hurtTimer = 4 / 6f;
            health -= 1;
        }

        public void MapBorders()
        {
            pos.X = Math.Max(Math.Min(pos.X, this.scene.Width-30),15);
            pos.Y = Math.Max(Math.Min(pos.Y, this.scene.Height-45),15);
        }

        protected override void Update()
        {
            currentAnimation.Update();

            if(hurtTimer > 0)
                this.hurtTimer -= FormMain.deltaTime;

            MapBorders();

        }
    }
}
