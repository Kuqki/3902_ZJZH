﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueBatDownMovingState : IEnemyState
    {
        private BlueBat BlueBat;
        private MainStage game;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public BlueBatDownMovingState(BlueBat BlueBat, IEnemyFactory factory)

        {
            die = false;
            this.BlueBat = BlueBat;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);

        }

        public void MoveUp()
        {
            BlueBat.State = new BlueBatUpMovingState(BlueBat, factory);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
            BlueBat.State = new BlueBatLeftMovingState(BlueBat, factory);

        }


        public void MoveRight()
        {
            BlueBat.State = new BlueBatRightMovingState(BlueBat, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            
            if (!die)
            {
                BlueBat.Position = BlueBat.Position + new Vector2(0, 1) * BlueBat.MovingSpeed;
            }

            else
            {
                deathtimer--;
            }
            if (deathtimer == 0)
            {
                BlueBat.exist = false;
            }
        }
        public void BreatheFire()
        {
            
            
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetUpMovingBlueBatSpriteSheet(), spriteBatch, Position);
            }
            else
            {
                this.GetSprite.Draw(Texture2DStorage.GetDeathSpriteSheet(), spriteBatch, Position);
            }
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}