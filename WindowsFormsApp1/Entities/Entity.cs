using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Survival.Entities;
using Survival.Engine;
using Survival.Models;
using System.Windows.Forms;

namespace Survival.Entities
{
    public abstract class Entity
    {
        public Vector2 pos;
        protected FormMain scene => FormMain.ActiveScene;

        public virtual float ZOffset => this.pos.Y;

        public Entity parent { get; set; }
        List<Entity> children = new List<Entity>();

        public Entity(Entity parent)
        {
            this.parent = parent;
            this.scene.AddEntities(this);
            if (parent != null)
            {
                this.parent.children.Add(this);
            }
        }
   
        public void RemoveEntity()
        {
            this.scene.RemoveEntity(this);

            if (parent != null)
                this.parent.children.Remove(this);

            for (int i = this.children.Count - 1; i >= 0; i--)
            {
                this.children[i].RemoveEntity();
            }
        }

        public void BaseUpdate()
        {
            Update();
            children.ForEach(e=>e.BaseUpdate());
        }

        protected virtual void Update()
        {
        }

        public virtual void Draw(Graphics g)
        {
        }

        public bool HasParent()
        {
            return parent != null;
        }
    }
}
