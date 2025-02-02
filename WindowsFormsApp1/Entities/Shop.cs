using Survival.Engine;
using Survival.Models;
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
    public class Shop : Entity
    {
        public Shop(Vector2 pos) : base(null)
        {
            this.pos = pos;
            new HitboxEntityComponent(this, 70, true);
            new RendererComponent(this, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\shop.png")), new StaticAnimation(179, 0, 0));
        }
    }     
}
