﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueOctLeftMovingState : IEnemyState
    {
        private BlueOct BlueOct;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }

        public BlueOctLeftMovingState(BlueOct blueoct, IEnemyFactory factory)
        {
            this.BlueOct = blueoct;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);
        }

        public void MoveUp()
        {
            BlueOct.State = new BlueOctUpMovingState(BlueOct, factory);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueOct.State = new BlueOctDownMovingState(BlueOct, factory);

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            BlueOct.State = new BlueOctRightMovingState(BlueOct, factory);
        }

        public void Update()
        {
            GetSprite.Update();
            BlueOct.Position = BlueOct.Position - new Vector2(1, 0) * BlueOct.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueOct.Position, new Vector2(-1, 0), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(Texture2DStorage.GetLeftMovingBlueOctorokSpriteSheet(),spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}