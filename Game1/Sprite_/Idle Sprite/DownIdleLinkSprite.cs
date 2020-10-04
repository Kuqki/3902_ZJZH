﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class DownIdleLinkSprite : ISprite
    {


        public DownIdleLinkSprite()
        {
        }

        public void Update()
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 96, 96);
            Rectangle destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetDownIdleLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
    }
}