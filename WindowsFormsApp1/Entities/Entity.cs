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
        public Vector2 pos = Vector2.Zero;

        public virtual float hitboxSize { get; }

        public int size {  get; set; }

        internal Form1 scene => Form1.ActiveScene;


        protected Entity parent;
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
            this.children.ForEach(e => e.RemoveEntity());
            if(parent!= null)
                this.parent.children.Remove(this);
        }


        protected virtual void SetParent(Entity entity)
        {
            this.parent = entity;
        }

        public void BaseUpdate()
        {
            Update();
            children.ForEach(e=>e.BaseUpdate());
        }
        protected abstract void Update();

        public virtual void Draw(Graphics g)
        {

        }

        public bool HasParent()
        {
            return parent != null;
        }
    }
}
