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
    public class Door : Entity
    {
        private RendererComponent renderer;

        private bool isOpen => Vector2.Distance(this.pos, this.scene.player.pos) <= 50;

        public Door(Vector2 pos) : base(null)
        {
            this.pos = pos;
            this.renderer = new RendererComponent(this, new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\doors.png")), new StaticAnimation(128, 0, 0));
        }
        protected override void Update()
        {
            this.scene.isShopOpen = this.isOpen;
        }

        public override void Draw(Graphics g)
        {
            renderer.SetAnimationConfiguration(new StaticAnimation(128, 0, isOpen ? 1 : 0));
            base.Draw(g);;         
        }
    }
}
