using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;
using System;

namespace FightAI {

    //This version of the AI waits out of range of attacks, then moves in to attack after the opponent attacks.
    public class PatientAI : AbstractAI {
        //ActionRecord (of enemy actions): 0 corresponds to a block (of user's attack), 1 is an attack, 2 is a move forward, 3 is a move backward.
        

        PatientAI(NPC avatar) {
            ActionRecord = new List<int>();
            MaxRecord = 5;
            QueueLength = 0;
            User = avatar;
        }

        public override void Decide(){
            const float RANGE = 2.5f;//the range of the default attack. I might pull the range of the attack from the move itself if I implement that later.
            if(Math.Abs(Distance)>RANGE) {
                User.Move((int)(Distance/Math.Abs(Distance)));
            } else {
                
            }
        }
    }
}