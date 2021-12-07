using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//needs the buttons to be named
namespace FightCharacter {
    public class Player : Character {

        void Update() {
            if(!master.paused && stuntime > 0) {
                stuntime--;
                if(stuntime == 0) {
                    combatState.Neutral(this);
                }
            }
            if(!master.paused || stuntime > 0) {
                getInput();
            }
        }

        void getInput() {
            if (Input.GetAxis("Horizontal") > 0.1) {
                Move(1);
            } else if (Input.GetAxis("Horizontal") < -0.1) {
                Move(-1);
            } else {
                Block();
            }

            //Debug.Log("Axis input: " + Input.GetAxis("Horizontal"));

            //Blocks if no key is pressed
            if(!Input.anyKey) {
                Block();
            }

            //
            if (Input.GetKey(KeyCode.E)) {
                Debug.Log("Attacking");
                Character HitPerson = combatState.Attack(this, Attack1);
                if(HitPerson != null) {
                    HitPerson.combatState.Hit(HitPerson, this, Attack1.damage);
                }
            }
            
        }
    }
}