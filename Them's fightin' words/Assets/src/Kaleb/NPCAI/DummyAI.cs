using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;
using System;

namespace FightAI {

    //This version of the AI is a punching bag, used for the tutorial. They do not fight back. They may move towards the player if they are very far away.
    public class DummyAI : AbstractAI {
        //ActionRecord: 0 corresponds to a block (of user's attack), 1 is an attack, 2 is a move forward, 3 is a move backward.
        

        public DummyAI(NPC avatar) {
            ActionRecord = new List<int>();
            //The maximum number of previous stored inputs. It's zero since this AI doesn't store records
            MaxRecord = 0;
            QueueLength = 0;
            User = avatar;
        }

        public override void Decide(){
            float RANGE = 8.0f;//the range past which the NPC approaches the player

            if(Math.Abs(Distance)>RANGE) {
                
                if(Distance > 0) {
                    User.Move(1);
                } else {
                    User.Move(-1);
                }

            }
        }

    }

}