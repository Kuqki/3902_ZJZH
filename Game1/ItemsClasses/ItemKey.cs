﻿using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ItemKey : IItem
    {
        private IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }

        private MainStage game;

        public bool exist { get; set; }


        public ItemKey(Vector2 Position, MainStage game)
        {
            this.game = game;

            this.Position = Position;
            
            exist = true;
            
            GetSprite = new GeneralSprite(30,50,1);
            

        }
        public void PickUp()
        {
            game.Link.KeyNumber += 1;
        }
        public void Update()
        {

            GetSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(Texture2DStorage.GetKeySpriteSheet(),spriteBatch, Position);
            }
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }

    }
}

