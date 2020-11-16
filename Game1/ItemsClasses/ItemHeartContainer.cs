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
    public class ItemHeartContainer : IItem
    {
        private IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }



        public bool exist { get; set; }


        public ItemHeartContainer(Vector2 Position)
        {


            this.Position = Position;
            
            exist = true;
            
            GetSprite = new GeneralSprite(96,96,1);
            

        }

        public void Update()
        {

            GetSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(Texture2DStorage.GetHeartContainerSpriteSheet(),spriteBatch, Position);
            }
        }

        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}

