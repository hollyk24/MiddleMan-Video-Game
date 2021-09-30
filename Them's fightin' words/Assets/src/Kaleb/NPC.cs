using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC : Character
{
Character enemy;
    void Update() {
        moveSelect;
    }

    void MoveSelect(){
        if(enemy.hurtbox.transform.x > hurtbox.transform.x && enemy.hurtbox.transform.x < hurtbox.transform.x + 1) {
          position+=0.1;
      }
    }
}