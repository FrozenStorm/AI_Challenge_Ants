using System;
using System.Collections.Generic;

/*
    Paarweise gehen als angriffsstragey
 */

namespace Ants
{

    class MyBot : Bot
    {
        // DoTurn is run once per turn
        Attacker atk = new Attacker();
        Defender def = new Defender();
        Explorer exp = new Explorer();
        public override void DoTurn(IGameState state)
        {
            atk.Handler(state);
            def.Handler(state);
            exp.Handler(state);
            atk.DoTurn(state);
            def.DoTurn(state);
            exp.DoTurn(state);
           
        }
        public static void Main(string[] args)
        {
            new Ants().PlayGame(new MyBot());
        }

    }

}