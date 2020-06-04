﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Sprite;

namespace Sprint2
{
    class IdleLinkLeftState : ILinkState
    {
        //Instance variables
        private Link link;
        private ISprite sprite;

        //Constructor with Link instance parameter
        public IdleLinkLeftState(Link link, Vector2 position)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateLinkIdleLeftGreenSprite(link.Position);
        }

        //Updates the State
        public void Update(){
            sprite.Update();
        }

        //Draws the sprite attached to the state
        public void Draw(SpriteBatch spriteBatch){
            sprite.Draw(spriteBatch);
        }

        //Damage Link
        public void DamageLink(){}

        //Use compass item
        public void UseItem(IItem item)
        {
            item.Use();
            link.State = new UseItemLeftState(link);
        }

        //Idle Link left
        public void SetLinkIdle(){
            //NO-OP
            //Already idle
        }

        //Moves Link left
        public void MoveLinkLeft(){
            link.State = new MovingLinkLeftState(link);
        }

        //Moves Link right
        public void MoveLinkRight(){
            link.State = new MovingLinkRightState(link);
        }

        //Moves Link up
        public void MoveLinkUp(){
            link.State = new MovingLinkUpState(link);
        }

        //Moves Link down
        public void MoveLinkDown(){
            link.State = new MovingLinkDownState(link);
        }

        //Link attacks
        public void Attack() {
            link.State = new AttackingLinkLeftState(link);
        }
    }
}