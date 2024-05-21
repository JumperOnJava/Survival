using Survival.Controllers;
using Survival.Engine;
using Survival.Models;
using Survival.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public class Tree : AliveEntity
    {
        public Tree(Vector2 pos) : base(pos, Sprites.Tree)
        {
            this.health = 5;
            new Hitbox(this, 15, true);
            SetAnimationConfiguration(new Animation(1, 80, FormMain.rnd.Next(0,3)));
        }

        public override void Hurt(Entity attacker)
        {
            base.Hurt(attacker);
            this.hurtTimer = 0.2f;
        }
        protected override void Update()
        {
            if (hurtTimer > 0)
                this.hurtTimer -= FormMain.deltaTime;

            if (this.health <= 0)
            {
                RemoveEntity();
                this.scene.IncrementWood();
            }
        }

        public override void Draw(Graphics g)
        {
            Point point = new Point((int)pos.X - currentAnimation.SpriteSize, (int)pos.Y - currentAnimation.SpriteSize);
            if (hurtTimer > 0)
            {
                point.Offset(FormMain.rnd.Next(-2, 3),FormMain.rnd.Next(-2,3));

            }
            var rect = new Rectangle(point, new Size(currentAnimation.SpriteSize*2, currentAnimation.SpriteSize*2));
            g.DrawImage(spriteSheet, rect, currentAnimation.XPos, currentAnimation.YPos, currentAnimation.SpriteSize, currentAnimation.SpriteSize, GraphicsUnit.Pixel);
        }
    }
}