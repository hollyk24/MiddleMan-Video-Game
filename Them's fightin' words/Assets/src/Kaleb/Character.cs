using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightStatePattern;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    #region VARS

    //list of combat states: Move, Block, Attack, Hit
    public FightState combatState;
    public int health;
    public float speed;

    public Rigidbody2D hurtbox;
    public Character enemy;
    public FGManager master;

    public FightMove Attack1;
    public FightMove Attack2;
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
        health = 100;
        combatState = "Move";
        enemy = En;
    }

    public Character() {
        speed = 5; 
        health = 100;
        combatState = "Move";
    }

    void Start() {
        combatState = "Move";      
    }
    
    public Character Attack() {
        combatState = "Attack";

        return null;
    }

    public void Block() {
        combatState = "Block";
    }

    public void Move(int direction) {
        combatState = "Move";
        if(direction > 0) {
            hurtbox.velocity = new Vector2(speed, 0);
        } else if(direction < 0) {
            hurtbox.velocity = new Vector2(-speed, 0);
        } else {
            hurtbox.velocity = new Vector2(0, 0);
        }
    }

    public void OnHit(Character opponent) {
        if(!opponent.combatState.Equals("Block")) {
            opponent.health-=10;
        }
    }
    #endregion
}