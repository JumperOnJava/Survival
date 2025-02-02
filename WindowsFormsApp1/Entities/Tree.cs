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
    public class Tree : Entity, DamageableEntity
    {
        public readonly HitboxEntityComponent hitbox;
        private RendererComponent renderer;
        private Vector2 originalPos;
        public HealthComponent healthComponent;

        public Tree(Vector2 pos) : base(null)
        {
            this.originalPos = pos;
            this.healthComponent = HealthComponent.createComponent(this, 5);
            this.hitbox = new HitboxEntityComponent(this, 15, true);
            this.renderer = new RendererComponent(this, Sprites.Tree, new StaticAnimation(80, 0, FormMain.rnd.Next(0, 3)));
            renderer.scale = 2;
        }
        void DamageableEntity.OnDamage(int currentHealth)
        {
            if(currentHealth <= 0)
            {
                RemoveEntity();
                this.scene.IncrementWood();
            }
        }
        public override void Draw(Graphics g)
        {
            if (healthComponent.hurtTimer > 0)
            {
                this.pos = originalPos + new Vector2(FormMain.rnd.Next(-2, 3), FormMain.rnd.Next(-2, 3));
            }
            else
            {
                this.pos = originalPos;
            }
        }
    }
}