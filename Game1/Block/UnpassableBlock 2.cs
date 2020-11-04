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
    public class UnpassableBlock : IBlock
    {
        public Vector2 Position { get; set; }
        
        

        public bool exist { get; set; }


        public UnpassableBlock(Vector2 Position)
        {


            this.Position = Position;
            exist = true;
            

        }
        public void Update()
        { 
        }
        public void Draw(SpriteBatch spritebatch) 
        {
        }
    }
}
