using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    #region VARS
    
    #endregion

    #region METHODS

    void Update() {
        if(stuntime > 0) {
            stuntime--;
            if(stuntime == 0) {
                combatState.Neutral(this, normalSprite);
            }
        }
        if(!master.paused || stuntime > 0) {
            Plan();
        }
    }

    void Plan() {
      if(enemy.hurtbox.transform.position.x > hurtbox.transform.position.x + 1) {
            Move(1);
        }
        if(enemy.hurtbox.transform.position.x < hurtbox.transform.position.x - 1) {
            Move(-1);
        }
    }

    #endregion
}