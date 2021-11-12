using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using Verse.AI;

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
