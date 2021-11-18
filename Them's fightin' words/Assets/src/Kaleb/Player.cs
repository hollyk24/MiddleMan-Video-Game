using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//needs the buttons to be named
public class Player : Character {

    void Update() {
        if(!master.paused) {
            getInput();
        }
    }

    void getInput() {
        if (Input.GetAxis("Horizontal") > 0.1) {
            Move(1);
        } else if (Input.GetAxis("Horizontal") < -0.1) {
            Move(-1);
        } else {
            Move(0);
        }

        if(!Input.anyKey) {
            Block();
        }

        if (Input.GetKey(KeyCode.E)) {
            Debug.Log("Attacking");
            Character HitPerson = combatState.Attack(this, Attack1, punchSprite);
            if(HitPerson != null) {
                HitPerson.combatState.Hit(HitPerson, this, Attack1.damage);
            }
        }
        
    }
}