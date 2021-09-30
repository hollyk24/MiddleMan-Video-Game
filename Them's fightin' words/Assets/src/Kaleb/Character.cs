using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Sprite))]
public class Character : MonoBehaviour
{
    string combatState;
    int health;
    int speed;
    Rigidbody2D hurtbox;
    Sprite body;
    Character enemy;

    void Start() {
        speed = 10; 
        health = 50;
        combatState = "Move";      
    }


    RigidBody2D Attack() {
        combatState = "Attack";
        if(Mathf.abs((float)enemy.hurtbox.transform.x - (float)hurtbox.transform.x) < 1.0f) {
            if(hurtbox.transform.x > enemy.hurtbox.transform.x) {
                enemy.hurtbox.transform.x -= 1.0;
            } else {
                enemy.hurtbox.transform.x += 1.0;
            }
            return enemy.hurtbox;
        }
        return hurtbox;
    }

    Block() {
        combatState = "Block";
    }

    Move(bool forward) {
        combatState = "Move";
        if(forward) {
            hurtbox.velocity = new Vector2(0.01*speed, body.velocity.y);
        } else {
            phurtbox.velocity = new Vector2(-0.01*speed, body.velocity.y);
        }
    }

    onHit(Character opponent) {
        if(!opponent.combatState.Equals("Block")) {
            opponent.health-=10;
        } else {
            if(hurtbox.transform.x > enemy.hurtbox.transform.x) {
                enemy.hurtbox.transform.x -= 2;
            } else {
                enemy.hurtbox.transform.x += 2;
            }
        }
    }

}