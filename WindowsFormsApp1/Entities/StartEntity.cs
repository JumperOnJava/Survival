﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Survival.Entities
{
    public class StartEntity : Entity
    {
        public float monsterTimer = 5;
        public bool firstTick = true;

        public override float hitboxSize => 0.0f;

        private void SpawnMonster()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, this.scene.Width); // Випадкова координата X в межах ширини форми
            int y = rnd.Next(0, this.scene.Height); // Випадкова координата Y в межах висоти форми

            Monster monster = new PlayerSpriteMonster(new Vector2(x, y));
            //entities.Add(monster);
            scene.AddEntities(monster);
        }

        public override void Update()
        {
            if (firstTick)
            {
                this.scene.player = new Player(new Vector2(10, 10));

                scene.AddEntities(this.scene.player);
                scene.AddEntities(new PlayerSpriteMonster(new Vector2(200, 200)));
                //scene.AddEntities(new Slime(new Vector2(300, 300)));

                firstTick = false;
            }


            /*
            monsterTimer -= Form1.deltaTime;

            if (monsterTimer < 0)
            {
                SpawnMonster();
                monsterTimer += 5;
            }
            */

        }
    }
}
