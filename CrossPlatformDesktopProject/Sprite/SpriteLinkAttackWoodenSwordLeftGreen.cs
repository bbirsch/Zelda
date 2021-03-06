﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Sprite
{
    public class SpriteLinkAttackWoodenSwordLeftGreen : ISprite
    {
        private Texture2D texture;
        private int currentFrame;
        private int totalFrames;
        private int currentTick;


        public SpriteLinkAttackWoodenSwordLeftGreen(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
            totalFrames = 4;
            currentTick = 0;
        }


        public void Update()
        {
            if (currentFrame < totalFrames)
            {
                //TODO:(Barry) Testing - Sloppy
                if (currentTick >= Constant.TicksPerFrameAttackSword)
                {
                    currentTick = 0;
                    currentFrame++;
                }
                currentTick++;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Vector2 weaponOffset = new Vector2(-11, 5);


            Rectangle sourceRectangleAvatar;
            Rectangle destinationRectangleAvatar;
            Rectangle sourceRectangleWeapon;
            Rectangle destinationRectangleWeapon;
            //Rectangle sourceRectangleProjectile;
            //Rectangle destinationRectangleProjectile;



               if (currentframe == 0)
            {
                 sourcerectangleavatar = new rectangle(432, 16, 16, 16);
                 destinationrectangleavatar = new rectangle((int)location.x, (int)location.y, 16 * constant.displayscalex, 16 * constant.displayscaley);

                 sourcerectangleweapon = new rectangle(432 + (int)weaponoffset.x, 16 + (int)weaponoffset.y, 11, 8);
                 destinationrectangleweapon = new rectangle((int)location.x + (int)weaponoffset.x * constant.displayscalex, (int)location.y + (int)weaponoffset.y * constant.displayscaley, 11 * constant.displayscalex, 8 * constant.displayscaley);

               }

            if (currentFrame == 1)
            {
                sourceRectangleAvatar = new Rectangle(464, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(464 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 11, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 11 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else if (currentFrame == 2)
            {
                sourceRectangleAvatar = new Rectangle(496, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                weaponOffset = new Vector2(-7, 5);
                sourceRectangleWeapon = new Rectangle(496 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 7, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 7 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else
            {
                sourceRectangleAvatar = new Rectangle(528, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                weaponOffset = new Vector2(-3, 5);
                sourceRectangleWeapon = new Rectangle(528 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 3, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 3 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);

            }


            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangleAvatar, sourceRectangleAvatar, Color.White);
            spriteBatch.Draw(texture, destinationRectangleWeapon, sourceRectangleWeapon, Color.White);
            spriteBatch.End();


        }
    }
}

