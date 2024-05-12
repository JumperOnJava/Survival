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

        internal Form1 scene;
   

        public void RemoveEntity()
        {
            this.scene.RemoveEntity(this);
        }


        public abstract void Update();

        public virtual void Draw(Graphics g)
        {

        }
    }
}
