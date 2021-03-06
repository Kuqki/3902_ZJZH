﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprite_.NPC_Sprite
{
    class OldManSprite : DownIdleLinkSprite
    {
        public OldManSprite()
        {
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 96, 96);
            Rectangle destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetOldManSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
