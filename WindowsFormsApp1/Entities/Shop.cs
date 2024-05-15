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
    public class Shop : MapEntity
    {
        public Shop(Vector2 pos) : base(pos, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\farmObjects.png")))
        {
            this.Radius = 15;
        }

        protected override void Update()
        {
            //base.Update();
            
        }


        public override void Draw(Graphics g)
        {
            g.DrawImage(spriteSheet, new Rectangle(new Point((int)pos.X, (int)pos.Y), new Size(158, 179)), 0, 191, 180, 200, GraphicsUnit.Pixel); //tree
        }

    }

        
}
