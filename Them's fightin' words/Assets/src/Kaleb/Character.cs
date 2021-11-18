using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightStatePattern;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    #region VARS

    public Sprite punchSprite;
    public Sprite normalSprite;

    //list of combat states: Move, Block, Attack, Hit
    public CharState combatState;
    public int health;
    public float speed;
    public int stuntime;

    public Rigidbody2D hurtbox;
    public Character enemy;
    public FGManager master;

    public FightMove Attack1;
    #endregion
    #region METHODS

    public Character(int hp, int spd, Character En) {
        speed = spd; 
        health = hp;
        combatState = new CharState();
        enemy = En;
    }

    public Character(Character En) {
        speed = 5; 
        health = 100;
        combatState = new CharState();
        enemy = En;
    }

    public Character() {
        speed = 5; 
        health = 100;
        combatState = new CharState();
    }

    void Start() {
        combatState = new CharState();
    }
    
    public void Attack() {
        combatState.Attack(this, Attack1, punchSprite);
    }

    public void Block() {
        combatState.Block(this);
    }

    public void Move(int direction) {
        combatState.Move(hurtbox, direction, speed);
    }

    public void Hit(Character opponent, int damage) {
        combatState.Hit(this, opponent, damage);
    }
    #endregion
}