﻿using Game1.Command;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class RightWoodenSwordState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        private int timer = 12;
        public IGeneralSprite GetSprite { get; set; }
        public RightWoodenSwordState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new GeneralSprite(120,72,4);
            this.game.ProjectileFactory.ProjectileList.Add(new ProjectileWoodenSword(GlobalDefinitions.Position, new Vector2(1, 0)));

        }
        //link has already faced up so no code for MoveUp()

        
        //Link will move up if 'w' was pressed while pressing 'z'
        public void MoveUp()
        {
            Link.State = new UpMovingState(Link, game);
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
            Link.State = new RightIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
        }
        public void UseItem()
        {

        }

        public void Update()
        {
            GetSprite.Update();
            timer--;
            if (timer == 0)
            {
                this.Stop();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(Texture2DStorage.GetRightWoodenSwordLinkSpriteSheet(),spriteBatch, GlobalDefinitions.Position);
            

        }
    }
}