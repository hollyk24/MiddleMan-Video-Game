using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightAI;

namespace FightCharacter {
    public class TestNPC : NPC
    {
        #region VARS
        public int InternalTimer;
        public AbstractAI AI;
        #endregion

        #region METHODS

        void Start() {
            AI = new DummyAI(this);
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
                AI.UpdateDistance(3.0f);
                Plan();
            }
        }

        /*
        The planning loop for the AI Enemies
        */
        public void Plan() {
            if(InternalTimer > 60) {
                AI.Decide();
                InternalTimer = 0;
            }
        }

        #endregion
    }
}