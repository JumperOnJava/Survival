using Survival.Engine;
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
    public class Door : AliveEntity
    {
        private bool isOpen => Vector2.Distance(this.pos, this.scene.player.pos) <= 50;

        public Door(Vector2 pos) : base(pos, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\doors.png")))
        {
        }
        protected override void Update()
        {
            this.scene.isShopOpen = this.isOpen;
        }

        public override void Draw(Graphics g)
        {
            SetAnimationConfiguration(new Animation(1, 128, isOpen ? 1 : 0));
            base.Draw(g);;         
        }
    }
}
