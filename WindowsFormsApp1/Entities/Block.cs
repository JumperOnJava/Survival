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
    public class Block : MapEntity
    {
        public Block(Vector2 pos) : base(pos, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\farmObjects.png")))
        {
            this.Radius = 15;
            new Hitbox(this, (int)Radius);
        }

        protected override void Update()
        {
            base.Update();
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, new Rectangle((int)pos.X + 50, (int)pos.Y + 70, 25, 25));

            //g.DrawRectangle(pen, new Rectangle((int)pos.X + 50, (int)pos.Y + 70, 25, 25));
        }
    }
}
