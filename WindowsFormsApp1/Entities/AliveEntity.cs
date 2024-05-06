using Survival.Engine;
using Survival.Models;
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
        public Vector2 pos = Vector2.Zero;
        public abstract float hitboxSize { get; }
        public bool isMoving { get; set; }
        //public int direction;
        public int health;
        public int speed { get; set; }

        public Direction Direction { get; set; }

        public IAnimationProvider currentAnimation;
        //public Animation currentAnimation = new Animation(1, 1, 1);

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

        public override void Draw(Graphics g)
        {

            var rect = new Rectangle(new Point((int)pos.X, (int)pos.Y), new Size(currentAnimation.SpriteSize, currentAnimation.SpriteSize));
            g.DrawImage(spriteSheet, rect, currentAnimation.XPos, currentAnimation.YPos, currentAnimation.SpriteSize, currentAnimation.SpriteSize, GraphicsUnit.Pixel);
            if (GetType() == typeof(Player))
                Console.WriteLine($"{currentAnimation.XPos}, {currentAnimation.YPos}");
        }

        public bool IntersectsWith(AliveEntity entity)
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

        public override void Update()
        {
            currentAnimation.Update();
        }
    }
}
