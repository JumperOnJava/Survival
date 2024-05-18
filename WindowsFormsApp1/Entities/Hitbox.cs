using Microsoft.CodeAnalysis.CSharp.Syntax;
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
    class Hitbox : Entity
    {
        private int Radius;

        private bool isStatic { get; set; }

        public Hitbox(Entity parent, int radius) : base(parent)
        {
            this.Radius = radius;
        }

        public Hitbox(Entity parent, int radius, bool isStatic) : this(parent, radius)
        {
            this.isStatic = isStatic;
        }

        protected override void Update()
        {
            if (this.parent == null)
                return;
            if (this.isStatic)
                return;
            foreach (var entity in this.scene.entities)
            {
                if (entity is Hitbox hitbox)
                {
                    var e1 = this.parent;
                    var e2 = hitbox.parent;
                    if (entity == this)
                    {
                        continue;
                    }
                    var intersects = Vector2.Distance(e1.pos, e2.pos) <= this.Radius + hitbox.Radius;
                    if (!hitbox.isStatic && intersects)
                    {
                        Vector2 mid = (e1.pos + e2.pos) / 2;

                        Vector2 O1 = e1.pos - mid;
                        O1 = O1.Normalized();
                        e1.pos = mid + O1 * this.Radius;

                        Vector2 O2 = e2.pos - mid;
                        O2 = O2.Normalized();
                        e2.pos = mid + O2 * hitbox.Radius;
                    }

                    if (hitbox.isStatic)
                    {
                        while (intersects)
                        {
                            var dist = e1.pos - e2.pos;
                            e1.pos = e2.pos + dist * 1.01f;
                            intersects = Vector2.Distance(e1.pos, e2.pos) <= this.Radius + hitbox.Radius;
                        }
                    }
                }
            }
        }
    }
}
