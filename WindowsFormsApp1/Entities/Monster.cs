using Survival.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public abstract class Monster : AliveEntity
    {
        //public bool isDead;

        //public override float hitboxSize => 32;

        public Monster(Vector2 pos, int health, int speed, Image spriteSheet) : base(pos, health, speed, spriteSheet)
        {
            this.speed = 70;
        }

        public virtual void DetermineMonsterAnimation(Player player) { }

        public abstract void UpdateMonsterMovement(Player player);

        public override void Update()
        {
            base.Update();
            if (this.health <= 0)
            {
                this.scene.score++;
                this.RemoveEntity();
                this.scene.AddEntities(new Corpse(this));
            }
            else
            {
                this.isMoving = true;
            }
            if (this.isMoving)
            {
                this.DetermineMonsterAnimation(scene.player);
            }
        }

    }
}
