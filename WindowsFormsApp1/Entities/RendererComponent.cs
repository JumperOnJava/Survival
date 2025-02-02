using Survival.Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Entities
{
    public class RendererComponent : Entity
    {
        internal float scale = 1;
        public override float ZOffset => parent.ZOffset;

        public RendererComponent(Entity parent, Image spriteSheet, IAnimationProvider initialAnimation) : base(parent)
        {
            this.spriteSheet = spriteSheet;
            currentAnimation = initialAnimation;
        }
        public override void Draw(Graphics g)
        {
            var rect = new Rectangle(
                new Point(
                    (int)(parent.pos.X - currentAnimation.SpriteSize *scale / 2), 
                    (int)(parent.pos.Y - currentAnimation.SpriteSize * scale / 2)), 
                new Size(
                    (int)(currentAnimation.SpriteSize * scale), 
                    (int)(currentAnimation.SpriteSize * scale)
                    ));
            g.DrawImage(spriteSheet, rect, currentAnimation.XPos, currentAnimation.YPos, currentAnimation.SpriteSize, currentAnimation.SpriteSize, GraphicsUnit.Pixel);
        }
        public Image spriteSheet { get; }
        public IAnimationProvider currentAnimation { get; private set; }

        public virtual void SetAnimationConfiguration(IAnimationProvider animation)
        {
            currentAnimation = animation;
        }
        protected override void Update()
        {
            currentAnimation.Update();
        }
    }
}
