using System;
using Raylib_cs;

namespace Raylibspel
{
    public class Player
    {
        public Rectangle rect = new Rectangle();

        public KeyboardKey upKey;
        public KeyboardKey downKey;
        public KeyboardKey leftKey;
        public KeyboardKey rightKey;

        public Player(float x, float y, KeyboardKey upKey, KeyboardKey downKey, KeyboardKey leftKey, KeyboardKey rightKey)
        {
            this.rect.x = x;
            this.rect.y = y;
            this.rect.height = 50;
            this.rect.width = 50;

            this.upKey = upKey;
            this.downKey = downKey;
            this.rightKey = rightKey;
            this.leftKey = leftKey;
        }

        public void Update()
        {
            if (Raylib.IsKeyDown(upKey))
            {
                this.rect.y -= 3f;
            }
            else if (Raylib.IsKeyDown(downKey))
            {
                this.rect.y += 3f;
            }
            else if (Raylib.IsKeyDown(leftKey))
            {
                this.rect.x -= 3f;
            }
            else if (Raylib.IsKeyDown(rightKey))
            {
                this.rect.x += 3f;
            }

            if (rect.y > 600 - rect.height)
            {
                this.rect.y = 600 - rect.height;
            }

            if (rect.y < 0)
            {
                this.rect.y = 0f;
            }

            if (rect.x < 0)
            {
                this.rect.x = 0f;
            }

            if (rect.x > 800 - rect.width)
            {
                this.rect.x = 800 - rect.width;
            }
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(this.rect, Color.BLACK);
        }
    }
}
