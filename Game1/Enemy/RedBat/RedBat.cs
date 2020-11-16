﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class RedBat : IEnemy
    {

        public IEnemyState State { get; set; }
        
        int count;
        Random rand;
        public bool exist { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int MovingSpeed = 1;


        public RedBat(Vector2 Position, Vector2 Direction, IEnemyFactory factory)
        {
            State = new RedBatUpMovingState(this, factory);
            this.Position = Position;
            rand = new Random();
            exist = true;
        }



        public void MoveUp()
        {
            State.MoveUp();
        }


        public void MoveDown()
        {
            State.MoveDown();
        }

        public void MoveLeft()
        {
            State.MoveLeft();
        }

        public void MoveRight()
        {
            State.MoveRight();
        }


        public void Attack()
        {
            State.BreatheFire();
        }



        public void Update()
        {
            State.Update();

            count++;
            if (count > GlobalDefinitions.phaseChangingSpeed)
            {
                switch (rand.Next(0, 5))
                {
                    case 0:
                        State.MoveUp();
                        break;
                    case 1:
                        State.MoveDown();
                        break;
                    case 2:
                        State.MoveLeft();
                        break;
                    case 3:
                        State.MoveRight();
                        break;
                    case 4:
                        State.MoveDown();
                        break;



                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                count = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.State.Draw(spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.State.GetRectangle();
        }


    }
}
