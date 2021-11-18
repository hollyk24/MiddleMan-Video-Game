using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//needs the buttons to be named
public class Player : Character {

    void Update() {
        if(!master.paused && combatState != "Hit" && combatState != "Attack") {
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
            Move(0);
        }

        if (Input.GetKey(KeyCode.E)) {
            Debug.Log("Attacking");
            combatState = "Attack";
            Attack1.CallMove();
            if (enemy.combatState == "Hit") {

                
            }
        }

        if (Input.GetKey(KeyCode.Q)) {
            Block();
        }
    }
}