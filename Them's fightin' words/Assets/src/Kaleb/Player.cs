using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//needs the buttons to be named
namespace FightCharacter {
    public class Player : Character {
        
        void Start() {
            BlockTimer = 0;
        }

        void Update() {
            if(!master.paused && stuntime > 0) {
                stuntime-=1;
                if(stuntime == 0) {
                    combatState.Neutral(this);
                }
            }
            if(!master.paused || stuntime > 0) {
                if(BlockTimer > 0) {
                    BlockTimer--;
                    if(BlockTimer == 0) {
                        this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                    }
                }
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
                Character HitPerson = Attack(Attack1);
                if(HitPerson != null) {
                    HitPerson.combatState.Hit(HitPerson, this, Attack1.damage);
                }
            }
            
        }
    }
}