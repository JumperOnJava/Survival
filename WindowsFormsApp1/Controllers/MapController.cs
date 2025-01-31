using Microsoft.CodeAnalysis.CSharp.Syntax;
using Survival.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Controllers
{
    public class MapController
    {
        public const int mapHeight = 20;
        public const int mapWidth = 20;
        public const int cellSize = 32;
        public const int layers = 2;

        public Image spriteSheet;
        private Tile[,,] map;

        public MapController()
        {
            InitializeMap();
        }

        public void InitializeMap()
        {
            map = new Tile?[layers, mapWidth, mapHeight];

            for (int j = 0; j < mapHeight; j++)
            {
                for (int i = 0; i < mapWidth; i++)
                {
                    Tile tile;

                    if (i == 0 && j == 0) tile = ForestSpriteSheet.SIDE_TOP_LEFT;
                    else if (i == mapWidth - 1 && j == 0) tile = ForestSpriteSheet.SIDE_TOP_RIGHT;
                    else if (i == 0 && j == mapHeight - 1) tile = ForestSpriteSheet.SIDE_BOTTOM_LEFT;
                    else if (i == mapWidth - 1 && j == mapHeight - 1) tile = ForestSpriteSheet.SIDE_BOTTOM_RIGHT;

                    else if (i == 0) tile = ForestSpriteSheet.SIDE_LEFT;
                    else if (j == 0) tile = ForestSpriteSheet.SIDE_TOP;
                    else if (i == mapWidth - 1) tile = ForestSpriteSheet.SIDE_RIGHT;
                    else if (j == mapHeight - 1) tile = ForestSpriteSheet.SIDE_BOTTOM;

                    else tile = ForestSpriteSheet.GROUND;

                    map[0, i, j] = tile;
                }
            }

            for (int i = 0; i <= 10; i++)
            {
                map[1, FormMain.rnd.Next(20), FormMain.rnd.Next(20)] = ForestSpriteSheet.ROCK;
            }
        }


        public void DrawMap(Graphics g)
        {
            for (int layer = 0; layer < layers; layer++)
            {
                for (int i = 0; i < mapWidth; i++)
                {
                    for (int j = 0; j < mapHeight; j++)
                    {
                        var rect = new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize));
                        map[layer, i, j]?.DrawTile(g, rect);
                    }
                }
            }
        }

        public int GetWidth()
        {
            return cellSize * (mapWidth) + 16;
        }

        public int GetHeight()
        {
            return cellSize * (mapHeight + 1) + 7;
        }

        public Vector2 GetPositionFromCell(int row, int column)
        {
            float x = column * cellSize;
            float y = row * cellSize;
            return new Vector2(x, y);
        }
    }

    public static class ForestSpriteSheet
    {
        static Image spriteSheet = (new Bitmap(Path.Combine(
            new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(),
            "Sprites\\Forest.png")));

        public static Tile SIDE_TOP_LEFT = spriteSheet.createTile(96, 0, 20, 20);
        public static Tile SIDE_BOTTOM_LEFT = spriteSheet.createTile(170, 0, 20, 20);
        public static Tile SIDE_TOP_RIGHT = spriteSheet.createTile(96, 75, 20, 20);
        public static Tile SIDE_BOTTOM_RIGHT = spriteSheet.createTile(170, 75, 20, 20);
        public static Tile SIDE_TOP = spriteSheet.createTile(96, 32, 20, 20);
        public static Tile SIDE_LEFT = spriteSheet.createTile(120, 0, 20, 20);
        public static Tile SIDE_BOTTOM = spriteSheet.createTile(171, 30, 20, 20);
        public static Tile SIDE_RIGHT = spriteSheet.createTile(120, 75, 20, 20);
        public static Tile GROUND = spriteSheet.createTile(0, 0, 20, 20);
        public static Tile ROCK = spriteSheet.createTile(581, 110, 20, 20);
    }

    public class Tile
    {
        public Image spriteSheet;
        public Rectangle spritePosition;

        public Tile(Image image, int x, int y, int width, int height)
        {
            this.spriteSheet = image;
            this.spritePosition = new Rectangle(x, y, width, height);
        }

        public void DrawTile(Graphics g, Rectangle renderPosition)
        {
            g.DrawImage(this.spriteSheet, renderPosition, spritePosition.Left, spritePosition.Top, spritePosition.Width,
                spritePosition.Height, GraphicsUnit.Pixel);
        }
    }

    public static class ImageExtend
    {
        public static Tile createTile(this Image spriteSheet, int x, int y, int width, int height)
        {
            return new Tile(spriteSheet, x, y, width, height);
        }
    }
}