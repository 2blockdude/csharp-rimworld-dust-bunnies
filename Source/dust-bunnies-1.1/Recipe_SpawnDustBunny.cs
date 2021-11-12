﻿using System.Collections.Generic;
using Verse;

namespace DustBunnies
{
    public class Recipe_SpawnDustBunny : RecipeWorker
    {
        public static PawnKindDef Pawn_DustBunny = DefDatabase<PawnKindDef>.GetNamed("DustBunny");

        public override void Notify_IterationCompleted(Pawn billDoer, List<Thing> ingredients)
        {
            Pawn dustBunny = PawnGenerator.GeneratePawn(Pawn_DustBunny, billDoer.Faction);
            GenSpawn.Spawn(dustBunny, billDoer.Position, billDoer.Map, Rot4.Random);
        }
    }
}
