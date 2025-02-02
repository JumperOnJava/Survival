using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Models
{
    public static class Sprites
    {
        public static readonly Image Shop = LoadSprite("shop.png");
        public static readonly Image Player = LoadSprite("player.png");
        public static readonly Image Heart = LoadSprite("heart.png");
        public static readonly Image Door = LoadSprite("doors.png");
        public static readonly Image ForestSheet = LoadSprite("Forest.png");
        public static readonly Image Ghost = LoadSprite("ghost.png");
        public static readonly Image Trees = LoadSprite("trees.png");
        
        private static Image LoadSprite(string name)
        {
            var path = Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Sprites", name);
            return new Bitmap(path);
        }
    }
}
