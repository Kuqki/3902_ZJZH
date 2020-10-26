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
    public class Aquamentus : IEnemy
    {

        public IEnemyState State { get; set; }
        private MainStage game;
        int count;
        Random rand;
        public bool exist { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int MovingSpeed = 1;

        public Aquamentus(Vector2 position, Vector2 direction)
        {
            State = new AquamentusLeftMovingState(this, game);
            this.Position = position;
            

            rand = new Random();
            
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
            if (count > 50)
            {
                switch (rand.Next(0, 5))
                {
                    case 0:
                        State.MoveRight();
                        break;
                    case 1:
                        State.BreatheFire();
                        break;
                    case 2:
                        State.MoveLeft();
                        break;
                    case 3:
                        State.BreatheFire();
                        break;
                    case 4:
                        State.BreatheFire();
                        break;



                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                count = 0;
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            if (exist)
            {
                State.Draw(spritebatch, this.Position);
            }
        }

        public Rectangle GetRectangle()
        {
            return this.State.GetRectangle();
        }


    }
}
