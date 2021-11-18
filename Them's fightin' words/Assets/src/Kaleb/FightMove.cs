using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
The class for the attacks used in the classic Fighting Game
*/

public class FightMove : MonoBehaviour {
    #region VARS

    public int startup; //length of startup in frames
    public int duration; //length of active hitbox in frames
    public int endlag; //length of endlag after move ends in frames
    
    public int cFrame; //tracks where in the animation the move currently is

    public int damage; //Amount of damage the move does
    public Collider2D hitbox;//The specific collider associated with this move.
    public bool active;

    public Character owner;

    #endregion

    #region CONSTRUCTORS

    /*
     * Constructor for a default move, passing only the collision box. 
     */
    public FightMove(Collider2D boxx) {
        startup = 0;
        duration = 10;
        endlag = 5;
        damage = 10;
        hitbox = boxx;
        active = false;
        cFrame = 0;
    }

    /*
     * Constructor for a fully customized move.
     */
    public FightMove (int s, int d, int e, int dmg, Collider2D boxx) {
        startup = s;
        duration = d;
        endlag = e;
        damage = dmg;
        hitbox = boxx;
        active = false;
        cFrame = 0;
    }

    #endregion

    #region METHODS

    /*
     * This method increments the move through it's active frames
     */
    void Update() {
        if(active) {
            cFrame++;
            if(cFrame >= startup + duration + endlag){
                active = false;
                owner.combatState = "Move";
            } 
        }
    }

    /*
     * CallMove() 
     */
    public void CallMove() {
        if(!active) {
            active = true;
            cFrame = 0;
        }
        
    }

    /*
     * This methods checks whether the move comes into contact with another player
     */
    void OnTriggerEnter2D(Collider2D HitObj) {
        //check that the move has begun
        if(active == false) {
            return;
        }
        //checks that the trigger is not from the user of the move(shouldn't happen unless hitboxes get wonky)
        if(HitObj.attachedRigidbody == owner.hurtbox) {
            return;
        }
        //check that the move is active
        if(cFrame > startup && cFrame <= startup+duration) {
            if(HitObj.GetComponent<Collider>().gameObject == owner.enemy.gameObject) {
                owner.enemy.combatState = "Hit";
            }
        }
    }

    #endregion 
}