﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2.Sprite
{
    public class SpriteProjectileMagicBoomerang : ISprite
    {
        private Texture2D texture;
        private int rows;
        private int columns;
        private int currentTick;
        private int currentFrame;
        private int totalFrames;
        private int ticksPerFrame;



        public SpriteProjectileMagicBoomerang(Texture2D texture)
        {
            this.texture = texture;
            rows = 1;
            columns = 4;
            currentFrame = 0;
            currentTick = 0;
            totalFrames = rows * columns;
            ticksPerFrame = 2;
        }


        public void Update()
        {
            if (currentTick >= ticksPerFrame)
            {
                currentTick = 0;
                currentFrame++;
                if (currentFrame >= totalFrames)
                    currentFrame = 0;
            }
            currentTick++;
        }


        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = this.texture.Width / columns;
            int height = this.texture.Height / rows;
            int row = (int)((float)currentFrame / (float)columns);
            int column = currentFrame % columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * Constant.DisplayScaleX, height * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(this.texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}