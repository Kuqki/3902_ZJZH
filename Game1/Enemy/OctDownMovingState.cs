﻿using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;

namespace Game1
{
    internal class OctDownMovingState : IOctState
    {
        private Oct Oct;
        private MainStage game;
        public ISprite GetSprite { get; set; }

        public OctDownMovingState(Oct oct, MainStage game)
        {
            this.Oct = oct;
            this.game = game;
            GetSprite = new DownMovingOctSprite();

        }

        public void MoveUp()
        {
            Oct.State = new OctUpMovingState(Oct, game);
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
        }


        public void MoveLeft()
        {
            Oct.State = new OctLeftMovingState(Oct, game);

        }


        public void MoveRight()
        {
            Oct.State = new OctRightMovingState(Oct, game);

        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void BreatheFire()
        {
            this.game.ProjectileFactory.AddArrow(GlobalDefinitions.OctPosition, new Vector2(0, 1));
        }

       
    }
}