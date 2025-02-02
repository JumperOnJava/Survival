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
    public abstract class MovingEntity : Entity, DirectionableEntity
    {      
        protected bool isMoving { get; set; }
        public int speed { get; set; }
        protected bool isAttacking = false;
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

        public MovingEntity(Vector2 pos, int speed) : base(null)
        {
            this.pos = pos;
            this.speed = speed;
        }

        public MovingEntity(Vector2 pos) : base(null)
        {
            this.pos = pos;
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

        public void MapBorders()
        {
            pos.X = Math.Max(Math.Min(pos.X, this.scene.Width-30),15);
            pos.Y = Math.Max(Math.Min(pos.Y, this.scene.Height-45),15);
        }

        protected override void Update()
        {
            MapBorders();
        }
    }
}
