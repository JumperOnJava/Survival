using Survival.Controllers;
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
        Random rnd = new Random();
        public float monsterTimer = 5;
        public float treeTimer = 10;
        public bool firstTick = true;

        public StartEntity() : base(null)
        {
        }

        public override float hitboxSize => 0.0f;

        private void SpawnMonster()
        {
           
            int x = rnd.Next(0, this.scene.Width - 120);
            int y = rnd.Next(0, this.scene.Height - 420);

            Monster monster = new PlayerSpriteMonster(new Vector2(x, y));
            scene.AddEntities(monster);
        }

        private void SpawnTree()
        {
            int x = rnd.Next(0, 18);
            int y = rnd.Next(0, 19);
            //bool free = true;
            Tree tree = new Tree(MapController.GetPositionFromCell(x, y));

            /*
            foreach (Entity entity in scene.entities)
            { 
                if (entity is Block)
                { 
                    Block block = (Block)entity;
                    if (tree.block.pos == block.pos)
                        free = false; break;
                }
            }
            */

            if ((MapController.map[x + 2, y] == 0))
            {
                //Tree tree = new Tree(MapController.GetPositionFromCell(x, y), x, y);
                //tree.pos.X -= 40;
                scene.AddEntities(tree);
                scene.AddEntities(tree.block);
                this.scene.entities.Add(tree);
                //scene.trees.Add(tree);

                //MapController.map[tree.mapX, tree.mapY] = 10;

                this.scene.treesCount++;
            }



        }

        protected override void Update()
        {
            if (firstTick)
            {
                this.scene.player = new Player(new Vector2(250, 350));

                scene.AddEntities(this.scene.player);

                for(int i = 0; i < this.scene.player.numHeart; i++) 
                {
                    Heart heart = new Heart(new Vector2((22 * i * 2 + 300), 37), i);

                    //scene.hearts.Add(heart);
                    scene.AddEntities(heart);
                
                }

                //scene.AddEntities(new PlayerSpriteMonster(new Vector2(200, 200)));
                //scene.AddEntities(new Slime(new Vector2(300, 300)));

              

                Block[,] blocksRoof = MapController.RowGeneratorBlocks(new Vector2(380, 280), 6, 2);
                Block[,] blocksRoom = MapController.RowGeneratorBlocks(new Vector2(390, 330), 5, 2);

                List<Block[,]> fullShopBlocks = new List<Block[,]>
                {
                    blocksRoof,
                    blocksRoom
                };

                foreach (Block[,] blockPart in fullShopBlocks)
                {
                    foreach (Block block in blockPart)
                    {
                        scene.AddEntities(block);
                        this.scene.entities.Add(block);
                    }


                    /*
                    Vector2 pos = MapController.GetCellFromPosition(block.pos);
                    int x = (int)pos.X;
                    int y = (int)pos.Y;
                    MapController.map[(int)MapController.GetCellFromPosition(block.pos).X, (int)MapController.GetCellFromPosition(block.pos).X] = 11;
                    */
                }

                Shop shop = new Shop(new Vector2(420, 280));
                scene.AddEntities(shop);
                this.scene.entities.Add(shop);
                Vector2 pos = MapController.GetCellFromPosition(shop.pos);
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        MapController.map[(int)MapController.GetCellFromPosition(blocksRoof[0, 0].pos).X + i + 1, (int)MapController.GetCellFromPosition(blocksRoof[0, 0].pos).Y + j ] = 11;
                        //MapController.map[(int)MapController.GetCellFromPosition(blocksRoom[2, 1].pos).X + i, (int)MapController.GetCellFromPosition(blocksRoom[0, 0].pos).Y + j] = 11;
                    }
                }

                Door door = new Door(new Vector2(489, 350)); //350
                scene.AddEntities(door);
                this.scene.entities.Add(door);


                while (this.scene.treesCount < 8)
                {
                    SpawnTree();
                }


                firstTick = false;
            }

          
            monsterTimer -= Form1.deltaTime;

            if (monsterTimer < 0)
            {
                //SpawnMonster();
                if (this.scene.score >= 5)
                    monsterTimer = 1;
                else if (this.scene.score >= 10)
                    monsterTimer = 0.5f;
                else monsterTimer = 5;
            }


            //SpawnTree();
            
            if (this.scene.treesCount <= 10)
            {
                treeTimer -= Form1.deltaTime;

                if (treeTimer < 0)
                {
                    SpawnTree();
                    treeTimer = 5;
                }
            }
            

        }
    }
}
