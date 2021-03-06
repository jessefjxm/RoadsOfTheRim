﻿using Verse;

namespace RoadsOfTheRim
{
    public class RoadBuildableDef : Def
    {
        public float movementCostMultiplier = 1f;
        public float biomeMovementDifficultyEffect = 0f;
        public string roadDef = "DirtPath" ;
        public int work = 0;
        public int wood = 0;
        public int stone = 0;
        public int steel = 0;
        public int chemfuel = 0;

        public string getRoadDef()
        {
            return this.roadDef;
        }
    }

}
