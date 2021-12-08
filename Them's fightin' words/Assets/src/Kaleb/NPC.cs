using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightAI;

namespace FightCharacter {
    public class NPC : Character
    {
        #region VARS
        public int InternalTimer;
        public bool Dummy;
        public AbstractAI AI;
        #endregion

        #region METHODS

        void Start() {
            //This is a temporary solution. Eventually NPC generation should be handled by the factory.
            if(Dummy) {
                AI = new DummyAI(this);
            } else {
                AI = new GenericAI(this);
            }
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
                if(BlockTimer > 0) {
                    BlockTimer--;
                    if(BlockTimer == 0) {
                        this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                    }
                }
                AI.UpdateDistance(enemy.hurtbox.transform.position.x  - hurtbox.transform.position.x);
                Plan();
            }
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
            //Debug.Log("NPC Hit");
            combatState.Hit(this, opponent, damage);
        }

        #endregion
    }
}