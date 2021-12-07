using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightAI;

namespace FightCharacter {
    public class NPC : Character
    {
        #region VARS
        public AbstractAI AI;
        public int InternalTimer;
        #endregion

        #region METHODS

        void Start() {
            InternalTimer = 0;
            //This is a temporary solution. Eventually NPC generation should be handled by the factory.
            AI = new GenericAI(this);
        }

        void Update() {
            InternalTimer++;
            //decreases stuntime each loop
            if(!master.paused && stuntime > 0) {
                stuntime--;
                if(stuntime == 0) {
                    combatState.Neutral(this);
                }
            }
            //stops the npc if they are stunned or the match is paused
            if(!master.paused || stuntime > 0) {
                UpdateAI();
                Plan();
            }
        }

        void UpdateAI() {
            AI.UpdateDistance(enemy.hurtbox.transform.position.x  - hurtbox.transform.position.x);
            //Record (of user actions): 0 is no action, 1 is a hit attack, 2 is a whiffed attack, 3 is a move forward, 4 is a move backward. Update at x intervals
            
        }

        /*
        The planning loop for the AI Enemies
        */
        void Plan() {
            if(InternalTimer > 60) {
                AI.Decide();
                InternalTimer = 0;
            }
        }

        //A custom Hit method for testing
        public override void Hit(Character opponent, int damage) {
            Debug.Log("NPC Hit");
            combatState.Hit(this, opponent, damage);
        }

        #endregion
    }
}