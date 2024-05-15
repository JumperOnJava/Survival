using Microsoft.CodeAnalysis.CSharp.Syntax;
using Survival.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{
    class Hitbox : Entity
    {
        private int Radius;

        public Hitbox(Entity parent,int radius) : base(parent) {
            this.Radius = radius;
        }
        protected override void Update()
        {
            foreach(var entity in this.scene.entities)
            {
                if(entity is Hitbox hitbox)
                {
                    var e1=this.parent;
                    var e2=hitbox.parent;
                    if (entity == this)
                    {
                        continue;
                    }

                    if (Vector2.Distance(e1.pos, e2.pos) < this.Radius + hitbox.Radius)
                    {
                        Vector2 mid = (e1.pos + e2.pos) / 2;
                        Vector2 O1 = e1.pos - mid;
                        Vector2 O2 = e2.pos - mid;
                        O1 = O1.Normalized();
                        O2 = O2.Normalized();
                        e1.pos = mid + O1 * this.Radius;
                        e2.pos = mid + O2 * hitbox.Radius;
                    }
                }
            }
        }
    }
}
