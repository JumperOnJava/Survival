using Survival.Engine;
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
    public class Shop : AliveEntity
    {
        public Shop(Vector2 pos) : base(pos, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\shop.png")))
        {
            new Hitbox(this, 70, true);
            SetAnimationConfiguration(new Animation(1, 179, 0));
        }
    }     
}
