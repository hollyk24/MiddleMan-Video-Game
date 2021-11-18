using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    #region VARS
    
    #endregion

    #region METHODS

    void Update() {
        if(!master.paused) {
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