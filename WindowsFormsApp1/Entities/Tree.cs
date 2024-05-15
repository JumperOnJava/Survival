using Survival.Controllers;
using Survival.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{

    public class Tree : MapEntity
    {
        public Block block { get; set; }
        public override float hitboxSize => 30;

        public bool isCutted = false;
   
        public Tree(Vector2 pos) : base(pos, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\Forest.png")))
        {
            this.health = 2;
            this.Radius = 15;
            this.block = new Block(new Vector2(this.pos.X - 35, this.pos.Y));
        }

        protected override void Update()
        {
            //base.Update();

            if (this.health <= 0)
            {
                //MapController.map[this.mapX, this.mapY] = 0;
                RemoveEntity();
                this.block.RemoveEntity();
                isCutted = true;

            }

        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(spriteSheet, new Rectangle(new Point((int)pos.X, (int)pos.Y), new Size(64, 96)), 330, 297, 50, 50, GraphicsUnit.Pixel); //tree
            block.Draw(g);
        }

    }
}




