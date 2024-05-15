using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public class Door : MapEntity
    {
        private bool filled  = true;
        public Block block { get; set; }
       
        public Door(Vector2 pos) : base(pos, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\farmObjects.png")))
        {
            this.Radius = 15;
        }

        protected override void Update()
        {
            //base.Update();
            if ((Vector2.Distance(this.pos - new Vector2(40, 0), this.scene.player.pos) <= 50))
            {
                this.filled = false;
            }
            else this.filled = true;

            this.scene.isShopOpen = this.filled;
        }

        public override void Draw(Graphics g)
        {
            if (filled)
                g.DrawImage(spriteSheet, new Rectangle(new Point((int)pos.X, (int)pos.Y), new Size(41, 100)), 200, 185, 60, 100, GraphicsUnit.Pixel);
            else
                g.DrawImage(spriteSheet, new Rectangle(new Point((int)pos.X, (int)pos.Y + 40), new Size(41, 100)), 200, 288, 60, 100, GraphicsUnit.Pixel);
        }


    }
}
