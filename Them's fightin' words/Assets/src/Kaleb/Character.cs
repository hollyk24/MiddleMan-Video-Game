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


    Rigidbody2D Attack() {
        combatState = "Attack";
        if(Mathf.Abs((float)enemy.hurtbox.transform.position.x - (float)hurtbox.transform.position.x) < 1.0f) {
            if(transform.position.x > enemy.transform.position.x) {
                enemy.transform.position -= new Vector3(1, 0);
            } else {
                enemy.transform.position += new Vector3(1, 0);
            }
            return enemy.hurtbox;
        }
        return hurtbox;
    }

    void Block() {
        combatState = "Block";
    }

    void Move(bool forward) {
        combatState = "Move";
        if(forward) {
            hurtbox.velocity = new Vector2(0.01f*speed, hurtbox.velocity.y);
        } else {
            hurtbox.velocity = new Vector2(-0.01f*speed, hurtbox.velocity.y);
        }
    }

    void onHit(Character opponent) {
        if(!opponent.combatState.Equals("Block")) {
            opponent.health-=10;
        } else {
            if(transform.position.x > enemy.transform.position.x) {
                enemy.transform.position -= new Vector3(2,0);
            } else {
                enemy.transform.position += new Vector3(2, 0);
            }
        }
    }

}