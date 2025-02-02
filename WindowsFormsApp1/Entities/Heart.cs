using Survival.Entities;
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
    public class Heart : Entity
    {
        private static Image spriteSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\heart.png"));
        private int order;
        public override float ZOffset => 100000;

        public Heart(Vector2 pos, int order) : base(null)
        {
            this.pos = pos;
            this.order = order;
        }

        public override void Draw(Graphics g)
        {
            var rect = new Rectangle(new Point((int)pos.X, (int)pos.Y), new Size(35, 30));
            if (this.scene.player.healthComponent.health > order)
                g.DrawImage(spriteSheet, rect, 0, 12, 12, 10, GraphicsUnit.Pixel);
            else
            {
                g.DrawImage(spriteSheet, rect, 12, 12, 12, 10, GraphicsUnit.Pixel);
            }
        }
    }
}
