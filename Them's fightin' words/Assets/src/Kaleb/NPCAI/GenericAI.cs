using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;
using System;

namespace FightAI {

    //This version of the AI just moves towards the opponents, waits, then attacks. It cycles through the last two options while in range.
    public class GenericAI : AbstractAI {
        //ActionRecord: 0 corresponds to a block (of user's attack), 1 is an attack, 2 is a move forward, 3 is a move backward.
        

        public GenericAI(NPC avatar) {
            ActionRecord = new List<int>();
            //The maximum number of previous stored inputs: It's low here since the AI is very simple
            MaxRecord = 1;
            QueueLength = 0;
            User = avatar;
        }

        public override void Decide(){
            float RANGE = 2.5f;//the range of the default attack. I might pull the range of the attack from the move itself if I implement that later.

            if(Math.Abs(Distance)>RANGE) {
                
                UpdateRecord(2);
                if(Distance > 0) {
                    User.Move(1);
                } else {
                    User.Move(-1);
                }

            } else {
                
                //if the previous action wasn't an attack
                if(ActionRecord[0] != 1) {
                    //attack
                    UpdateRecord(1);
                    User.Attack();
                } else {
                    //othewise move backwards
                    UpdateRecord(3);
                    if(Distance > 0) {
                        User.Move(-1);
                    } else {
                        User.Move(1);
                    }
                }

            }
        }

    }

}