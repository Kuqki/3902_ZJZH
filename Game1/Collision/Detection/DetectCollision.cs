﻿using Game1.Collision;
using Game1.CollisionHandler;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game1.Collision.CollisionHandler;
namespace Game1.Detection
{
    public class DetectCollision
    {
        public ILink link;
        public List<IBlock> BlockList;
        public List<IEnemy> EnemyList;
        public IProjectileFactory projectileFactory;
        public List<IItem> ReceivedItemList;
        public List<IItem> ObtainedItemList;
        public DetectCollision()
        {
        }
        public void linkBlockDetection(ILink link, List<IBlock> BlockList)
        {
            this.link = link;
            this.BlockList = BlockList;
            foreach (IBlock block in BlockList)
            {
                Rectangle linkRectangle = link.GetRectangle();
                Rectangle BlockRectangle = block.GetRectangle();
                Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, BlockRectangle).GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, BlockRectangle).ifCollision();
                IHandler LinkBlockCollisionHandler = new LinkBlockCollisionHandler(link, block, side, intersectRectangle);
                LinkBlockCollisionHandler.Execute();
            }
        }

        public void LinkEnemyDetection(ILink link, List<IEnemy> EnemyList)
        {
            this.link = link;
            this.EnemyList = EnemyList;
            if (link.timer == 0)
            {
                foreach (IEnemy enemy in EnemyList)
                {
                    if (enemy.exist)
                    {
                        Rectangle linkRectangle = link.GetRectangle();
                        Rectangle EnemyRectangle = enemy.GetRectangle();
                        Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, EnemyRectangle).GetRectangle();

                        ICollision side = new GeneralDetection(linkRectangle, EnemyRectangle).ifCollision();
                        IHandler LinkEnemyCollisionHandler = new LinkEnemyCollisionHandler(enemy, link, side, intersectRectangle);
                        LinkEnemyCollisionHandler.Execute();
                    }
                }
            }
        }

        public void linkReceivedItemDetection(ILink link, List<IItem> ReceivedItemList)
        {
            this.link = link;
            this.ReceivedItemList = ReceivedItemList;
            foreach (IItem item in ReceivedItemList)
            {
                Rectangle linkRectangle = link.GetRectangle();
                Rectangle ItemRectangle = item.GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, ItemRectangle).ifCollision();
                IHandler LinkReceivedItemCollision = new LinkReceivedItemCollisionHandler(link, item, side);
                LinkReceivedItemCollision.Execute();
            }
        }

        public void linkObtainedItemDetection(ILink link, List<IItem> ObtainedItemList)
        {
            this.link = link;
            this.ObtainedItemList = ObtainedItemList;
            foreach (IItem item in ObtainedItemList)
            {
                Rectangle linkRectangle = link.GetRectangle();
                Rectangle ItemRectangle = item.GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, ItemRectangle).ifCollision();
                IHandler LinkObtainedItemCollision = new LinkObtainedItemCollisionHandler(link, item, side);
                LinkObtainedItemCollision.Execute();
            }
        }

        public void EnemyBlockDetection(List<IEnemy> EnemyList, List<IBlock> BlockList)
        {
            this.EnemyList = EnemyList;
            this.BlockList = BlockList;
            ICollision side = ICollision.Null;
            foreach (IEnemy enemy in EnemyList)
            {
                if (enemy.exist)
                {
                    foreach (IBlock block in BlockList)
                    {
                        Rectangle EnemyRectangle = enemy.GetRectangle();
                        Rectangle BlockRectangle = block.GetRectangle();
                        Rectangle intersectRectangle = new GeneralDeterctionIntersect(EnemyRectangle, BlockRectangle).GetRectangle();
                         side = new GeneralDetection(EnemyRectangle, BlockRectangle).ifCollision();
                        IHandler EnemyBlockCollisionHandler = new EnemyBlockCollisionHandler(enemy, block, side, intersectRectangle);
                        EnemyBlockCollisionHandler.Execute();
                    }
                }

            }

        }

        public void EnemyProjectileDetection(List<IEnemy> EnemyList, IProjectileFactory projectileFactory)
        {
            this.EnemyList = EnemyList;
            this.projectileFactory = projectileFactory;
            List<IProjectile> projectileList = projectileFactory.ProjectileList;
            foreach (IEnemy enemy in EnemyList)
            {
                if (enemy.exist)
                {
                    foreach (IProjectile projectile in projectileList)
                    {
                        Rectangle EnemyRectangle = enemy.GetRectangle();
                        Rectangle projectileRectangle = projectile.GetRectangle();
                        ICollision side = new GeneralDetection(EnemyRectangle, projectileRectangle).ifCollision();
                        IHandler EnemyProjectileCollision = new EnemyProjectileCollisonHandler(enemy, projectile, side);
                        EnemyProjectileCollision.Execute();
                    }
                }

            }

        }
    }
}
