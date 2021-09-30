using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//needs the buttons to be named
public class Player : Character
{
    void Update() {
        getInput();
    }

    
    void getInput() {
        if(Input.GetAxis("Horizontal") > 0.1) {
            Move(true);
        }

        if(Input.GetAxis("Horizontal") < -0.1){
            Move(false);
        }

        if(Input.GetButton("Attack"))
        {
            RigidBody2D enemyBody = Attack();
            if(enemybody = enemy.hurtbox){
                OnHit(enemy);
            }
        }

        if(Input.GetButton("Block"))
        {
            Block();
        }
    }
}