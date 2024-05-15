using Survival.Controllers;
using Survival.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public abstract class MapEntity : AliveEntity
    {
        public MapEntity(Vector2 pos, Image spriteSheet) : base(pos, spriteSheet)
        {
        }



        protected override void Update()
        {
            //base.Update();
            //CheckCollision();

        }

        public override void CheckCollision()
        {
            foreach (var entity in this.scene.entities)
            {
                if (entity == this || entity is MapEntity)
                {
                    continue;
                }
                if (!(entity is AliveEntity))
                {
                    continue;
                }

                AliveEntity entity2 = (AliveEntity)entity;

                if (Vector2.Distance(this.pos, entity.pos) < this.Radius + entity2.Radius)
                {
                    Vector2 mid = (this.pos + entity.pos) / 2;
                    //Vector2 O1 = this.pos - mid;
                    Vector2 O2 = entity.pos - mid;
                    //O1 = O1.Normalized();
                    O2 = O2.Normalized();
                    // У дерева нічого не змінюється
                    entity.pos = mid + O2 * entity2.Radius;
                }
            }
        }

    }
}
