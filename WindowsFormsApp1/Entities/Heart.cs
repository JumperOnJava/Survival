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
        public Image spriteSheet { get; set; }
        public bool filled = true;
        public int order {  get; set; }

        public Heart(Vector2 pos, int order) : this(pos, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\heart.png")))
        {
            this.order = order;
        }

        public Heart(Vector2 pos, Image spriteSheet) : base(null)
        {
            this.pos = pos;
            this.spriteSheet = spriteSheet;
        }

        protected override void Update()
        {
            if (this.scene.player.arrHearts[this.order] == 1)
            {
                this.filled = true;
            }
            else this.filled = false;
        }

        public override void Draw(Graphics g)
        {
            var rect = new Rectangle(new Point((int)pos.X, (int)pos.Y), new Size(35, 30));
            if (filled)
                g.DrawImage(spriteSheet, rect, 0, 12, 12, 10, GraphicsUnit.Pixel);
            else
            {
                g.DrawImage(spriteSheet, rect, 12, 12, 12, 10, GraphicsUnit.Pixel);
            }
        }
    }
}
