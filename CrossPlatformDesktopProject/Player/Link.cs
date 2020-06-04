﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Eventing.Reader;

namespace Sprint2.Player
{
    class Link : IPlayer
    {
        //Instance variables
        private ILinkState state;

        private IItem item;

        private static Vector2 position;

        //Properties
        public ILinkState State
        {
            get { return state; }
            set { state = value; }
        }

        public IItem Item
        {
            get { return item; }
            set { item = value; }
        }

        //No parameter constructor, initializes Link to the down idle state
        public Link()
        {
            //Can change starting position later
            position = Constant.LinkStartPosition;

            state = new IdleLinkDownState(this, position);
        }

        //Updates the player
        public void Update()
        {
            state.Update();
        }

        //Draws the player
        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            state.Draw(spriteBatch, texture);
        }

        //Damage Link
        public void DamagePlayer() {
            state.DamageLink();
        }

        //Use item
        public void UseItem() {
            state.UseItem(item);
        }

        //Sets link to the idle state
        public void SetIdle()
        {
            state.SetLinkIdle();
        }

        //Sets link to the moving left state
        public void MovePlayerLeft()
        {
            state.MoveLinkLeft();
        }

        //Sets link to the moving right state
        public void MovePlayerRight()
        {
            state.MoveLinkRight();
        }

        //Sets link to the moving up state
        public void MovePlayerUp()
        {
            state.MoveLinkUp();
        }

        //Sets link to the moving down state
        public void MovePlayerDown()
        {
            state.MoveLinkDown();
        }

        //Player attacks
        public void Attack() {
            state.Attack();
        }

        //Moves Link left
        public void MoveLeft()
        {
            if(position.X > 0)
            {
                position.X--;
            }
        }

        //Moves Link right
        public void MoveRight()
        {
            if(position.X < Constant.ScreenWidth)
            {
                position.X++;
            }
        }

        //Moves Link up
        public void MoveUp()
        {
            if(position.Y > 0)
            {
                position.Y--;
            }
        }

        //Moves Link down
        public void MoveDown()
        {
            if(position.Y < Constant.ScreenHeight)
            {
                position.Y++;
            }
        }
    }
}