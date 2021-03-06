﻿using Game1;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{

    public static class Texture2DStorage
    {
        // Note that we are not using Game1's ContentLoader here (outside the scope of class methods) since it has not been instantiated yet
        private static Texture2D UpIdleLinkSpriteSheet;
        private static Texture2D UpMovingLinkSpriteSheet;
        private static Texture2D UpUseItemSpriteSheet;
        private static Texture2D DownIdleLinkSpriteSheet;
        private static Texture2D DownMovingLinkSpriteSheet;
        private static Texture2D DownUseItemSpriteSheet;
        private static Texture2D LeftIdleLinkSpriteSheet;
        private static Texture2D LeftMovingLinkSpriteSheet;
        private static Texture2D LeftUseItemSpriteSheet;
        private static Texture2D RightIdleLinkSpriteSheet;
        private static Texture2D RightMovingLinkSpriteSheet;
        private static Texture2D RightUseItemSpriteSheet;
        private static Texture2D UpWoodenSwordLinkSpriteSheet;
        private static Texture2D DownWoodenSwordLinkSpriteSheet;
        private static Texture2D LeftWoodenSwordLinkSpriteSheet;
        private static Texture2D RightWoodenSwordLinkSpriteSheet;

        private static Texture2D UpWoodenArrowSpriteSheet;
        private static Texture2D DownWoodenArrowSpriteSheet;
        private static Texture2D LeftWoodenArrowSpriteSheet;
        private static Texture2D RightWoodenArrowSpriteSheet;
        private static Texture2D BombSpriteSheet;
        private static Texture2D BoomerSpriteSheet;

        private static Texture2D DamagedLinkSpriteSheet;

        private static Texture2D ArrowSpriteSheet;
        private static Texture2D BombItemSpriteSheet;
        private static Texture2D BoomerangSpriteSheet;
        private static Texture2D BowSpriteSheet;
        private static Texture2D ClockSpriteSheet;
        private static Texture2D CompassSpriteSheet;
        private static Texture2D HeartContainerSpriteSheet;
        private static Texture2D KeySpriteSheet;
        private static Texture2D MapSpriteSheet;
        private static Texture2D FairySpriteSheet;
        private static Texture2D HeartSpriteSheet;
        private static Texture2D RupeeSpriteSheet;
        private static Texture2D TriforceSpriteSheet;
        private static Texture2D BlueBlockSpriteSheet;
        private static Texture2D BlueFaceBlockSpriteSheet;
        private static Texture2D BlueStoneBlockSpriteSheet;

        private static Texture2D BombedDoorUpSpriteSheet;
        private static Texture2D BombedDoorDownSpriteSheet;
        private static Texture2D BombedDoorLeftSpriteSheet;
        private static Texture2D BombedDoorRightSpriteSheet;

        private static Texture2D LockedDoorUpSpriteSheet;
        private static Texture2D LockedDoorDownSpriteSheet;
        private static Texture2D LockedDoorLeftSpriteSheet;
        private static Texture2D LockedDoorRightSpriteSheet;

        private static Texture2D OpenDoorUpSpriteSheet;
        private static Texture2D OpenDoorDownSpriteSheet;
        private static Texture2D OpenDoorLeftSpriteSheet;
        private static Texture2D OpenDoorRightSpriteSheet;

        private static Texture2D ShutDoorUpSpriteSheet;
        private static Texture2D ShutDoorDownSpriteSheet;
        private static Texture2D ShutDoorLeftSpriteSheet;
        private static Texture2D ShutDoorRightSpriteSheet;

        private static Texture2D WallUpSpriteSheet;
        private static Texture2D WallDownSpriteSheet;
        private static Texture2D WallLeftSpriteSheet;
        private static Texture2D WallRightSpriteSheet;

        private static Texture2D BrickTileSpriteSheet;
        private static Texture2D GapTileSpriteSheet;
        private static Texture2D LadderTileSpriteSheet;
        private static Texture2D StairsSpriteSheet;
        private static Texture2D FireSpriteSheet;

        private static Texture2D UpOctorokSpriteSheet;
        private static Texture2D DownOctorokSpriteSheet;
        private static Texture2D LeftOctorokSpriteSheet;
        private static Texture2D RightOctorokSpriteSheet;

        private static Texture2D UpBlueOctorokSpriteSheet;
        private static Texture2D DownBlueOctorokSpriteSheet;
        private static Texture2D LeftBlueOctorokSpriteSheet;
        private static Texture2D RightBlueOctorokSpriteSheet;

        private static Texture2D UpBlueMSpriteSheet;
        private static Texture2D DownBlueMSpriteSheet;
        private static Texture2D LeftBlueMSpriteSheet;
        private static Texture2D RightBlueMSpriteSheet;

        private static Texture2D UpRedBatSpriteSheet;
        private static Texture2D DownRedBatSpriteSheet;
        private static Texture2D LeftRedBatSpriteSheet;
        private static Texture2D RightRedBatSpriteSheet;

        private static Texture2D UpBlueBatSpriteSheet;
        private static Texture2D DownBlueBatSpriteSheet;
        private static Texture2D LeftBlueBatSpriteSheet;
        private static Texture2D RightBlueBatSpriteSheet;

        private static Texture2D UpBlueGoriyaSpriteSheet;
        private static Texture2D DownBlueGoriyaSpriteSheet;
        private static Texture2D LeftBlueGoriyaSpriteSheet;
        private static Texture2D RightBlueGoriyaSpriteSheet;

        private static Texture2D UpRedGoriyaSpriteSheet;
        private static Texture2D DownRedGoriyaSpriteSheet;
        private static Texture2D LeftRedGoriyaSpriteSheet;
        private static Texture2D RightRedGoriyaSpriteSheet;

        private static Texture2D LeftAquamentusSpriteSheet;
        private static Texture2D RightAquamentusSpriteSheet;

        private static Texture2D OldManSpriteSheet;
        private static Texture2D OldWomanSpriteSheet;

        private static Texture2D MerchantRSpriteSheet;
        private static Texture2D MerchantPSpriteSheet;
        private static Texture2D MerchantGSpriteSheet;
        private static Texture2D FireBallSpriteSheet;

        private static Texture2D FullMapSpriteSheet;

        private static Texture2D LinkUseItemSpriteSheet;

        private static Texture2D RoomExteriorSpriteSheet;

        public static Texture2D HeadExteriorSpriteSheet;

        private static Texture2D InventoryExteriorSpriteSheet;
        private static Texture2D RedSelectionRecSpriteSheet;

        private static Texture2D HeartNoBloodSpriteSheet;
        private static Texture2D HeartHalfBloodSpriteSheet;
        private static Texture2D HeartFullBloodSpriteSheet;
        private static Texture2D DeathSpriteSheet;

        private static Texture2D InventoryBackgroundSpriteSheet;
        private static Texture2D RedSelectionSpriteSheet;

        private static Texture2D BlackBackgroundSpriteSheet;
        private static Texture2D BombSelectSpritSheet;
        private static Texture2D BoomerSelectSpriteSheet;

        private static SpriteFont font;


        // More private static Texture2D fields follow
        // ...

        // static classes have no constructor, but we need a method to initialize the Texture2D fieldsw
        public static void LoadAllTextures(ContentManager content)
        {
            InventoryExteriorSpriteSheet = content.Load<Texture2D>("images/Inventory/Inventory");
            RedSelectionRecSpriteSheet = content.Load<Texture2D>("images/Inventory/RedSelectionRec");
            HeadExteriorSpriteSheet = content.Load<Texture2D>("images/Head/Head");
            HeartNoBloodSpriteSheet = content.Load<Texture2D>("images/Head/HeartNoBlood");
            HeartHalfBloodSpriteSheet = content.Load<Texture2D>("images/Head/HeartHalfBlood");
            HeartFullBloodSpriteSheet = content.Load<Texture2D>("images/Head/HeartFullBlood");
            FullMapSpriteSheet = content.Load<Texture2D>("images/fullmap");
            RoomExteriorSpriteSheet = content.Load<Texture2D>("images/RoomExterior");

            UpIdleLinkSpriteSheet = content.Load<Texture2D>("images/UpIdle");
            UpMovingLinkSpriteSheet = content.Load<Texture2D>("images/UpMoving");
            UpUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponBack");

            LeftIdleLinkSpriteSheet = content.Load<Texture2D>("images/LeftIdle");
            LeftMovingLinkSpriteSheet = content.Load<Texture2D>("images/LeftMoving");
            LeftUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponLeft");

            DownIdleLinkSpriteSheet = content.Load<Texture2D>("images/DownIdle");
            DownMovingLinkSpriteSheet = content.Load<Texture2D>("images/DownMoving");
            DownUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponFront");

            RightIdleLinkSpriteSheet = content.Load<Texture2D>("images/RightIdle");
            RightMovingLinkSpriteSheet = content.Load<Texture2D>("images/RightMoving");
            RightUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponRight");

            UpWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/UpWoodenSword");
            DownWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/DownWoodenSword");
            LeftWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/LeftWoodenSword");
            RightWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/RightWoodenSword");

            UpWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/UpArrow");
            DownWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/DownArrow");
            LeftWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/LeftArrow");
            RightWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/RightArrow");

            BombSpriteSheet = content.Load<Texture2D>("images/projectile/Bomb");
            BoomerSpriteSheet = content.Load<Texture2D>("images/projectile/Boomerang");

            DamagedLinkSpriteSheet = content.Load<Texture2D>("images/DamagedLink");

            //Items
            ArrowSpriteSheet = content.Load<Texture2D>("images/Item/Arrow");
            BombItemSpriteSheet = content.Load<Texture2D>("images/Item/Bomb");
            BoomerangSpriteSheet = content.Load<Texture2D>("images/Item/Boomerang");

            BowSpriteSheet = content.Load<Texture2D>("images/Item/Bow");
            ClockSpriteSheet = content.Load<Texture2D>("images/Item/Clock");
            CompassSpriteSheet = content.Load<Texture2D>("images/Item/Compass");

            HeartContainerSpriteSheet = content.Load<Texture2D>("images/Item/HeartContainer");
            KeySpriteSheet = content.Load<Texture2D>("images/Item/Key");
            MapSpriteSheet = content.Load<Texture2D>("images/Item/Map");


            FairySpriteSheet = content.Load<Texture2D>("images/Item/Fairy");
            HeartSpriteSheet = content.Load<Texture2D>("images/Item/Heart");
            RupeeSpriteSheet = content.Load<Texture2D>("images/Item/Rupy");
            TriforceSpriteSheet = content.Load<Texture2D>("images/Item/Triforce");
            //block
            BlueBlockSpriteSheet = content.Load<Texture2D>("images/Block/BlueBlock");
            BlueFaceBlockSpriteSheet = content.Load<Texture2D>("images/Block/BlueFaceBlock");
            BlueStoneBlockSpriteSheet = content.Load<Texture2D>("images/Block/BlueStoneBlock");
            BrickTileSpriteSheet = content.Load<Texture2D>("images/Block/BrickTile");
            GapTileSpriteSheet = content.Load<Texture2D>("images/Block/GapTile");
            LadderTileSpriteSheet = content.Load<Texture2D>("images/Block/LadderTile");
            StairsSpriteSheet = content.Load<Texture2D>("images/Block/Stairs");
            FireSpriteSheet = content.Load<Texture2D>("images/Block/Fire");

            //Doors

            BombedDoorDownSpriteSheet = content.Load<Texture2D>("images/Door/BombedDoorDown");
            BombedDoorLeftSpriteSheet = content.Load<Texture2D>("images/Door/BombedDoorLeft");
            BombedDoorRightSpriteSheet = content.Load<Texture2D>("images/Door/BombedDoorRight");
            BombedDoorUpSpriteSheet = content.Load<Texture2D>("images/Door/BombedDoorRight");

            LockedDoorUpSpriteSheet = content.Load<Texture2D>("images/Door/LockedDoorUp");
            LockedDoorDownSpriteSheet = content.Load<Texture2D>("images/Door/LockedDoorDown");
            LockedDoorLeftSpriteSheet = content.Load<Texture2D>("images/Door/LockedDoorLeft");
            LockedDoorRightSpriteSheet = content.Load<Texture2D>("images/Door/LockedDoorRight");

            OpenDoorUpSpriteSheet = content.Load<Texture2D>("images/Door/OpenDoorUp");
            OpenDoorDownSpriteSheet = content.Load<Texture2D>("images/Door/OpenDoorDown");
            OpenDoorLeftSpriteSheet = content.Load<Texture2D>("images/Door/OpenDoorLeft");
            OpenDoorRightSpriteSheet = content.Load<Texture2D>("images/Door/OpenDoorRight");

            ShutDoorUpSpriteSheet = content.Load<Texture2D>("images/Door/ShutDoorUp");
            ShutDoorDownSpriteSheet = content.Load<Texture2D>("images/Door/ShutDoorDown");
            ShutDoorLeftSpriteSheet = content.Load<Texture2D>("images/Door/ShutDoorLeft");
            ShutDoorRightSpriteSheet = content.Load<Texture2D>("images/Door/ShutDoorRight");

            WallUpSpriteSheet = content.Load<Texture2D>("images/Door/WallUp");
            WallDownSpriteSheet = content.Load<Texture2D>("images/Door/WallDown");
            WallLeftSpriteSheet = content.Load<Texture2D>("images/Door/WallLeft");
            WallRightSpriteSheet = content.Load<Texture2D>("images/Door/WallRight");

            //enemy

            UpOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokUp");
            DownOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokDown");
            LeftOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokLeft");
            RightOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokRight");

            UpBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueUp");
            DownBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueODown");
            LeftBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueLeft");
            RightBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueORight");

            UpBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMUp");
            DownBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMDown");
            LeftBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMLeft");
            RightBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMRight");

            UpBlueBatSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueBat/BlueBatUp");
            DownBlueBatSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueBat/BlueBatDown");
            LeftBlueBatSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueBat/BlueBatLeft");
            RightBlueBatSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueBat/BlueBatRight");

            UpRedBatSpriteSheet = content.Load<Texture2D>("images/Enemy/RedBat/RedBatUp");
            DownRedBatSpriteSheet = content.Load<Texture2D>("images/Enemy/RedBat/RedBatDown");
            LeftRedBatSpriteSheet = content.Load<Texture2D>("images/Enemy/RedBat/RedBatLeft");
            RightRedBatSpriteSheet = content.Load<Texture2D>("images/Enemy/RedBat/RedBatRight");


            UpBlueGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueGoriya/BlueGoriyaUp");
            DownBlueGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueGoriya/BlueGoriyaDown");
            LeftBlueGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueGoriya/BlueGoriyaLeft");
            RightBlueGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueGoriya/BlueGoriyaRight");

            UpRedGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/RedGoriya/RedGoriyaUp");
            DownRedGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/RedGoriya/RedGoriyaDown");
            LeftRedGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/RedGoriya/RedGoriyaLeft");
            RightRedGoriyaSpriteSheet = content.Load<Texture2D>("images/Enemy/RedGoriya/RedGoriyaRight");

            LeftAquamentusSpriteSheet = content.Load<Texture2D>("images/Enemy/Aquamentus/AquamentusLeft");
            RightAquamentusSpriteSheet = content.Load<Texture2D>("images/Enemy/Aquamentus/AquamentusRight");

            UpBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMUp");
            DownBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMDown");
            LeftBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMLeft");
            RightBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMRight");

            OldManSpriteSheet = content.Load<Texture2D>("images/Npc/OldMan");
            OldWomanSpriteSheet = content.Load<Texture2D>("images/Npc/OldWoman");
            MerchantRSpriteSheet = content.Load<Texture2D>("images/Npc/MerchantR");
            MerchantPSpriteSheet = content.Load<Texture2D>("images/Npc/MerchantP");
            MerchantGSpriteSheet = content.Load<Texture2D>("images/Npc/MerchantG");
            FireBallSpriteSheet = content.Load<Texture2D>("images/projectile/flame");
            DamagedLinkSpriteSheet = content.Load<Texture2D>("images/DamagedLink");
            LinkUseItemSpriteSheet = content.Load<Texture2D>("images/LinkUseItem");

            DeathSpriteSheet = content.Load<Texture2D>("images/Death");
            InventoryBackgroundSpriteSheet = content.Load<Texture2D>("images/InventoryMenuBackGround");
            RedSelectionSpriteSheet = content.Load<Texture2D>("images/RedSelection");
            BlackBackgroundSpriteSheet = content.Load<Texture2D>("images/blackbackground");
            BombSelectSpritSheet = content.Load<Texture2D>("images/BombSelect");
            BoomerSelectSpriteSheet = content.Load<Texture2D>("images/BoomerSelect");

            font = content.Load<SpriteFont>("Score");

            // More Content.Load calls follow
            //...
        }
        public static Texture2D GetInventoryExteriorSpriteSheet()
        {
            return InventoryExteriorSpriteSheet;
        }

        public static Texture2D GetRedSelectionRecSpriteSheet()
        {
            return RedSelectionRecSpriteSheet;
        }

        public static Texture2D GetHeadExteriorSpriteSheet()
        {
            return HeadExteriorSpriteSheet;
        }
        public static Texture2D GetHeartNoBloodSpriteSheet()
        {
            return HeartNoBloodSpriteSheet;
        }
        public static Texture2D GetHeartHalfBloodSpriteSheet()
        {
            return HeartHalfBloodSpriteSheet;
        }

        public static Texture2D GetHeartFullBloodSpriteSheet()
        {
            return HeartFullBloodSpriteSheet;
        }

        public static void UnloadAllTextures()
        {
            // unload all the Texture2Ds - not needed for the scope of this project
        }

        public static Texture2D GetFullMapSpriteSheet()
        {
            return FullMapSpriteSheet;
        }

        public static Texture2D GetRoomExteriorSpriteSheet()
        {
            return RoomExteriorSpriteSheet;
        }


        public static Texture2D GetDamagedLinkSpriteSheet()
        {
            return DamagedLinkSpriteSheet;
        }

        public static Texture2D GetUpIdleLinkSpriteSheet()
        {
            return UpIdleLinkSpriteSheet;
        }

        public static Texture2D GetUpMovingLinkSpriteSheet()
        {
            return UpMovingLinkSpriteSheet;
        }

        public static Texture2D GetUpUseItemLinkSpriteSheet()
        {
            return UpUseItemSpriteSheet;
        }






        public static Texture2D GetDownIdleLinkSpriteSheet()
        {
            return DownIdleLinkSpriteSheet;
        }

        public static Texture2D GetDownMovingLinkSpriteSheet()
        {
            return DownMovingLinkSpriteSheet;
        }

        public static Texture2D GetDownUseItemLinkSpriteSheet()
        {
            return DownUseItemSpriteSheet;
        }

        public static Texture2D GetLeftIdleLinkSpriteSheet()
        {
            return LeftIdleLinkSpriteSheet;
        }

        public static Texture2D GetLeftMovingLinkSpriteSheet()
        {
            return LeftMovingLinkSpriteSheet;
        }

        public static Texture2D GetLeftUseItemLinkSpriteSheet()
        {
            return LeftUseItemSpriteSheet;
        }

        public static Texture2D GetRightIdleLinkSpriteSheet()
        {
            return RightIdleLinkSpriteSheet;
        }

        public static Texture2D GetRightMovingLinkSpriteSheet()
        {
            return RightMovingLinkSpriteSheet;
        }

        public static Texture2D GetRightUseItemLinkSpriteSheet()
        {
            return RightUseItemSpriteSheet;
        }

        public static Texture2D GetUpWoodenSwordLinkSpriteSheet()
        {
            return UpWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetDownWoodenSwordLinkSpriteSheet()
        {
            return DownWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetLeftWoodenSwordLinkSpriteSheet()
        {
            return LeftWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetRightWoodenSwordLinkSpriteSheet()
        {
            return RightWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetUpWoodenArrowSpriteSheet()
        {
            return UpWoodenArrowSpriteSheet;
        }

        public static Texture2D GetDownWoodenArrowSpriteSheet()
        {
            return DownWoodenArrowSpriteSheet;
        }

        public static Texture2D GetLeftWoodenArrowSpriteSheet()
        {
            return LeftWoodenArrowSpriteSheet;
        }

        public static Texture2D GetRightWoodenArrowSpriteSheet()
        {
            return RightWoodenArrowSpriteSheet;
        }

        public static Texture2D GetBombSpriteSheet()
        {
            return BombSpriteSheet;
        }
        public static Texture2D GetBoomerSpriteSheet()
        {
            return BoomerSpriteSheet;
        }
        public static Texture2D GetArrowSpriteSheet()
        {
            return ArrowSpriteSheet;
        }

        public static Texture2D GetItemBombSpriteSheet()
        {
            return BombItemSpriteSheet;
        }
        public static Texture2D GetBoomerangSpriteSheet()
        {
            return BoomerangSpriteSheet;
        }

        public static Texture2D GetBowSpriteSheet()
        {
            return BowSpriteSheet;
        }
        public static Texture2D GetClockSpriteSheet()
        {
            return ClockSpriteSheet;
        }
        public static Texture2D GetCompassSpriteSheet()
        {
            return CompassSpriteSheet;
        }


        public static Texture2D GetHeartContainerSpriteSheet()
        {
            return HeartContainerSpriteSheet;
        }
        public static Texture2D GetKeySpriteSheet()
        {
            return KeySpriteSheet;
        }
        public static Texture2D GetMapSpriteSheet()
        {
            return MapSpriteSheet;
        }


        public static Texture2D GetFairySpriteSheet()
        {
            return FairySpriteSheet;
        }
        public static Texture2D GetHeartSpriteSheet()
        {
            return HeartSpriteSheet;
        }
        public static Texture2D GetRupeeSpriteSheet()
        {
            return RupeeSpriteSheet;
        }
        public static Texture2D GetTriforceSpriteSheet()
        {
            return TriforceSpriteSheet;
        }
        //blocks
        public static Texture2D GetBlueBlockSpriteSheet()
        {
            return BlueBlockSpriteSheet;
        }
        public static Texture2D GetBlueFaceBlockSpriteSheet()
        {
            return BlueFaceBlockSpriteSheet;
        }
        public static Texture2D GetBlueStoneBlockSpriteSheet()
        {
            return BlueStoneBlockSpriteSheet;
        }

        public static Texture2D GetBrickTileSpriteSheet()
        {
            return BrickTileSpriteSheet;
        }
        public static Texture2D GetGapTileSpriteSheet()
        {
            return GapTileSpriteSheet;
        }
        public static Texture2D GetLadderTileSpriteSheet()
        {
            return LadderTileSpriteSheet;
        }
        public static Texture2D GetStairsSpriteSheet()
        {
            return StairsSpriteSheet;
        }

        public static Texture2D GetFireSpriteSheet()
        {
            return FireSpriteSheet;
        }
        //Doors
        public static Texture2D GetBombedDoorUpSpriteSheet()
        {
            return BombedDoorUpSpriteSheet;
        }
        public static Texture2D GetBombedDoorDownSpriteSheet()
        {
            return BombedDoorDownSpriteSheet;
        }
        public static Texture2D GetBombedDoorLeftSpriteSheet()
        {
            return BombedDoorLeftSpriteSheet;
        }
        public static Texture2D GetBombedDoorRightSpriteSheet()
        {
            return BombedDoorRightSpriteSheet;
        }
        public static Texture2D GetLockedDoorUpSpriteSheet()
        {
            return LockedDoorUpSpriteSheet;
        }
        public static Texture2D GetLockedDoorDownSpriteSheet()
        {
            return LockedDoorDownSpriteSheet;
        }
        public static Texture2D GetLockedDoorLeftSpriteSheet()
        {
            return LockedDoorLeftSpriteSheet;
        }
        public static Texture2D GetLockedDoorRightSpriteSheet()
        {
            return LockedDoorRightSpriteSheet;
        }

        public static Texture2D GetOpenDoorUpSpriteSheet()
        {
            return OpenDoorUpSpriteSheet;
        }
        public static Texture2D GetOpenDoorDownSpriteSheet()
        {
            return OpenDoorDownSpriteSheet;
        }
        public static Texture2D GetOpenDoorLeftSpriteSheet()
        {
            return OpenDoorLeftSpriteSheet;
        }
        public static Texture2D GetOpenDoorRightSpriteSheet()
        {
            return OpenDoorRightSpriteSheet;
        }

        public static Texture2D GetShutDoorUpSpriteSheet()
        {
            return ShutDoorUpSpriteSheet;
        }
        public static Texture2D GetShutDoorDownSpriteSheet()
        {
            return ShutDoorDownSpriteSheet;
        }
        public static Texture2D GetShutDoorLeftSpriteSheet()
        {
            return ShutDoorLeftSpriteSheet;
        }
        public static Texture2D GetShutDoorRightSpriteSheet()
        {
            return ShutDoorRightSpriteSheet;
        }

        public static Texture2D GetWallUpSpriteSheet()
        {
            return WallUpSpriteSheet;
        }
        public static Texture2D GetWallDownSpriteSheet()
        {
            return WallDownSpriteSheet;
        }
        public static Texture2D GetWallLeftSpriteSheet()
        {
            return WallLeftSpriteSheet;
        }
        public static Texture2D GetWallRightSpriteSheet()
        {
            return WallRightSpriteSheet;
        }


        public static Texture2D GetUpMovingOctorokSpriteSheet()
        {
            return UpOctorokSpriteSheet;
        }

        public static Texture2D GetDownMovingOctorokSpriteSheet()
        {
            return DownOctorokSpriteSheet;
        }

        public static Texture2D GetLeftMovingOctorokSpriteSheet()
        {
            return LeftOctorokSpriteSheet;
        }

        public static Texture2D GetRightMovingOctorokSpriteSheet()
        {
            return RightOctorokSpriteSheet;
        }

        public static Texture2D GetUpMovingBlueOctorokSpriteSheet()
        {
            return UpBlueOctorokSpriteSheet;
        }

        public static Texture2D GetDownMovingBlueOctorokSpriteSheet()
        {
            return DownBlueOctorokSpriteSheet;
        }

        public static Texture2D GetLeftMovingBlueOctorokSpriteSheet()
        {
            return LeftBlueOctorokSpriteSheet;
        }

        public static Texture2D GetRightMovingBlueOctorokSpriteSheet()
        {
            return RightBlueOctorokSpriteSheet;
        }

        public static Texture2D GetUpMovingBlueMSpriteSheet()
        {
            return UpBlueMSpriteSheet;
        }

        public static Texture2D GetDownMovingBlueMSpriteSheet()
        {
            return DownBlueMSpriteSheet;
        }

        public static Texture2D GetLeftMovingBlueMSpriteSheet()
        {
            return LeftBlueMSpriteSheet;
        }

        public static Texture2D GetRightMovingBlueMSpriteSheet()
        {
            return RightBlueMSpriteSheet;
        }

        public static Texture2D GetUpMovingBlueBatSpriteSheet()
        {
            return UpBlueBatSpriteSheet;
        }

        public static Texture2D GetDownMovingBlueBatSpriteSheet()
        {
            return DownBlueBatSpriteSheet;
        }

        public static Texture2D GetLeftMovingBlueBatSpriteSheet()
        {
            return LeftBlueBatSpriteSheet;
        }

        public static Texture2D GetRightMovingBlueBatSpriteSheet()
        {
            return RightBlueBatSpriteSheet;
        }


        public static Texture2D GetUpMovingBlueGoriyaSpriteSheet()
        {
            return UpBlueGoriyaSpriteSheet;
        }

        public static Texture2D GetDownMovingBlueGoriyaSpriteSheet()
        {
            return DownBlueGoriyaSpriteSheet;
        }

        public static Texture2D GetLeftMovingBlueGoriyaSpriteSheet()
        {
            return LeftBlueGoriyaSpriteSheet;
        }

        public static Texture2D GetRightMovingBlueGoriyaSpriteSheet()
        {
            return RightBlueGoriyaSpriteSheet;
        }

        public static Texture2D GetUpMovingRedGoriyaSpriteSheet()
        {
            return UpRedGoriyaSpriteSheet;
        }

        public static Texture2D GetDownMovingRedGoriyaSpriteSheet()
        {
            return DownRedGoriyaSpriteSheet;
        }

        public static Texture2D GetLeftMovingRedGoriyaSpriteSheet()
        {
            return LeftRedGoriyaSpriteSheet;
        }

        public static Texture2D GetRightMovingRedGoriyaSpriteSheet()
        {
            return RightRedGoriyaSpriteSheet;
        }

        public static Texture2D GetLeftMovingAquamentusSpriteSheet()
        {
            return LeftAquamentusSpriteSheet;
        }

        public static Texture2D GetRightMovingAquamentusSpriteSheet()
        {
            return RightAquamentusSpriteSheet;
        }


        public static Texture2D GetUpMovingRedBatSpriteSheet()
        {
            return UpRedBatSpriteSheet;
        }

        public static Texture2D GetDownMovingRedBatSpriteSheet()
        {
            return DownRedBatSpriteSheet;
        }

        public static Texture2D GetLeftMovingRedBatSpriteSheet()
        {
            return LeftRedBatSpriteSheet;
        }

        public static Texture2D GetRightMovingRedBatSpriteSheet()
        {
            return RightRedBatSpriteSheet;
        }

        public static Texture2D GetOldManSpriteSheet()
        {
            return OldManSpriteSheet;
        }

        public static Texture2D GetOldWomanSpriteSheet()
        {
            return OldWomanSpriteSheet;
        }

        public static Texture2D GetMerchantRSpriteSheet()
        {
            return MerchantRSpriteSheet;
        }

        public static Texture2D GetMerchantPSpriteSheet()
        {
            return MerchantPSpriteSheet;
        }

        public static Texture2D GetMerchantGSpriteSheet()
        {
            return MerchantGSpriteSheet;
        }


        public static Texture2D GetLinkUseItemSpriteSheet()
        {
            return LinkUseItemSpriteSheet;
        }



        public static Texture2D GetLeftAquamentusSpriteSheet()
        {
            return LeftAquamentusSpriteSheet;
        }

        public static Texture2D GetRightAquamentusSpriteSheet()
        {
            return RightAquamentusSpriteSheet;
        }

        public static Texture2D GetFireBallSpriteSheet()
        {
            return FireBallSpriteSheet;
        }

        public static Texture2D GetDeathSpriteSheet()
        {
            return DeathSpriteSheet;
        }

        public static Texture2D GetInventoryBackgroundSpriteSheet()
        {
            return InventoryBackgroundSpriteSheet;
        }

        public static Texture2D GetRedSelectionSpriteSheet()
        {
            return RedSelectionSpriteSheet;
        }

        public static Texture2D GetBlackBackgroundSpriteSheet()
        {
            return BlackBackgroundSpriteSheet;
        }

        public static Texture2D GetBombSelectSpriteSheet()
        {
            return BombSelectSpritSheet;
        }

        public static Texture2D GetBoomerSelectSpriteSheet()
        {
            return BoomerSelectSpriteSheet;
        }
        public static SpriteFont GetFont()
        {
            return font;
        }

    }

}