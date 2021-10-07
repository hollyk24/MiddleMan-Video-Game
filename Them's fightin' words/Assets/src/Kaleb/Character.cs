using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    #region VARS

    public string combatState;
    public int health = 50;
    public int speed;
    public Rigidbody2D hurtbox;
    public Character enemy;

    #endregion
    #region UNITY
    void Start() {
        speed = 5; 
        health = 50;
        combatState = "Move";      
    }

    #endregion
    #region METHODS
    public Character(int hp, int spd, Character En) {
        speed = spd; 
        health = hp;
        combatState = "Move";
        enemy = En;
    }

    public Character(Character En) {
        speed = 5; 
        health = 50;
        combatState = "Move";
        enemy = En;
    }

    public Character() {
        speed = 5; 
        health = 50;
        combatState = "Move";
    }

    public Character Attack() {
        combatState = "Attack";
        if(Mathf.Abs((float)enemy.transform.position.x - (float)transform.position.x) < 1.0f) {
            if(transform.position.x > enemy.transform.position.x) {
                enemy.transform.position = new Vector3(enemy.transform.position.x -5.0f, enemy.transform.position.y, enemy.transform.position.z);
            } else {
                enemy.transform.position = new Vector3(enemy.transform.position.x +5.0f, enemy.transform.position.y, enemy.transform.position.z);
            }
            enemy.combatState = "Hit";
            return enemy;
        }
        return null;
    }

    public void Block() {
        combatState = "Block";
    }

    public void Move(bool forward) {
        combatState = "Move";
        if(forward) {
            transform.position = new Vector3(0.01f*speed+transform.position.x, transform.position.y, transform.position.z);
        } else {
            transform.position = new Vector3(transform.position.x-0.01f*speed, transform.position.y, transform.position.z);
        }
    }

    public void OnHit(Character opponent) {
        if(!opponent.combatState.Equals("Block")) {
            opponent.health-=10;
        } else {
            if(hurtbox.transform.position.x > enemy.hurtbox.transform.position.x) {
                enemy.transform.position = new Vector3(enemy.transform.position.x -2.0f, enemy.transform.position.y, enemy.transform.position.z);
            } else {
                enemy.transform.position = new Vector3(enemy.transform.position.x +2.0f, enemy.transform.position.y, enemy.transform.position.z);
            }
        }
    }
    #endregion
}