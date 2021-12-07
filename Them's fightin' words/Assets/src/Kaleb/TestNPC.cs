using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FightCharacter {
    public class TestNPC : Character
    {
        #region VARS
        
        #endregion

        #region METHODS

        void Update() {
            if(stuntime > 0) {
                stuntime--;
                if(stuntime == 0) {
                    combatState.Neutral(this);
                }
            }
            if(stuntime > 0) {
                Plan();
            }
        }

        /*
        The planning loop for the AI Enemies
        */
        void Plan() {
            Move(-1);
        }

        public override void Hit(Character opponent, int damage) {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f);
            Debug.Log("NPC Hit");
            combatState.Hit(this, opponent, damage);
        }

        #endregion
    }
}