﻿using Game1.Command;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game1
{
    public class UpMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public IGeneralSprite GetSprite { get; set; }
        public UpMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new GeneralSprite(72, 72, 2);

        }
        //link has already faced up so no code for MoveUp()

        
        public void MoveUp()
        {

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.

        public void MoveDown()
        {
            Link.State = new DownMovingState(Link, game);
        }

        public void MoveLeft()
        {
            Link.State = new LeftMovingState(Link, game);
        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);
        }

        public void Stop()
        {
            Link.State = new UpIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new UpWoodenSwordState(Link, game);
        }
        public void UseItem()
        {
            Link.State = new UpUseItemState(Link, game);
        }

        public void Update()
        {
            GetSprite.Update();
            GlobalDefinitions.Position += new Vector2(0,-10);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(Texture2DStorage.GetUpMovingLinkSpriteSheet(),spriteBatch, GlobalDefinitions.Position);

        }
    }
}