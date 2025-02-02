﻿using Survival.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Survival.Entities
{
    public class StartEntity : Entity
    {
        private float monsterTimer = 5;
        private float treeTimer = 2;
        private bool firstTick = true;

        public StartEntity() : base(null)
        {
        }

        private void SpawnMonster()
        {       
            int x = FormMain.rnd.Next(0, this.scene.Width - 120);
            int y = FormMain.rnd.Next(0, this.scene.Height - 420);

            Monster monster = new Ghost(new Vector2(x, y));
            scene.AddEntities(monster);
        }

        private void SpawnTree()
        {
            bool isPositionValid = true;
            int x = FormMain.rnd.Next(1, 19);
            int y = FormMain.rnd.Next(1, 20);

            Tree tree = new Tree(scene.map.GetPositionFromCell(x, y));

            foreach (var entity in this.scene.entities)
            {
                if (!(entity is Hitbox))
                    continue;
                if (entity == tree.hitbox)
                    continue;

                Hitbox hitbox = (Hitbox)entity;

                if (tree.hitbox.IntersectsWith(hitbox))
                    return;
            }

            scene.AddEntities(tree);
            this.scene.IncrementTree();
        }

        protected override void Update()
        {
            if (firstTick)
            {
                this.scene.player = new Player(new Vector2(250, 350));

                scene.AddEntities(this.scene.player);

                for(int i = 0; i < this.scene.player.health; i++) 
                {
                    Heart heart = new Heart(new Vector2((22 * i * 2 + 300), 37), i);
                    scene.AddEntities(heart);           
                }

                Shop shop = new Shop(new Vector2(500, 400));
                scene.AddEntities(shop);

                Door door = new Door(new Vector2(500, 460));
                scene.AddEntities(door);
               
                
                while (this.scene.treesCount < 15)
                {
                    SpawnTree();
                }  
                              
                firstTick = false;
            }
         
            monsterTimer -= FormMain.deltaTime;

            if (monsterTimer < 0)
            {
                SpawnMonster();
                if (this.scene.score >= 5)
                    monsterTimer = 1;
                else if (this.scene.score >= 10)
                    monsterTimer = 0.5f;
                else monsterTimer = 5;
            }

            if (this.scene.treesCount < 15)
            {
                treeTimer -= FormMain.deltaTime;

                if (treeTimer < 0)
                {
                    SpawnTree();
                    treeTimer = 2;
                }
            }
        }
    }
}
