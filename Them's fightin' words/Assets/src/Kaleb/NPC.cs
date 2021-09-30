using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC : Character
{

    void Update() {
        if(enemy.hurtbox.transform.position.x > hurtbox.transform.position.x + 1) {
          Move(true);
        }
        if(enemy.hurtbox.transform.position.x < hurtbox.transform.position.x - 1) {
          Move(false);
        }
    }

}