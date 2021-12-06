using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

//use the state design pattern
namespace FightStatePattern {

/**
Handles actions taken during the transitions from the Neutral State
**/
    public class NeutralState : FightState {

        /*
        The Action for the Transition from the Neutral state to the Move state
        
        */
        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            //Debug.Log(Actor.gameObject.name + " Move out of Neutral.");
            if(Direction > 0) {
                Actor.velocity = new Vector2(Speed, 0);
            } else if(Direction < 0) {
                Actor.velocity = new Vector2(-Speed, 0);
            } else {
                Actor.velocity = new Vector2(0, 0);
            }
        }

        /*
        The Action for the Transition from the Neutral state to the Attack state
        
        */
        public Character Attack(Character Actor, FightMove Atk) {
            //Debug.Log(Actor.gameObject.name + " Attack out of Neutral.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
            return Atk.CallMove();
        }

        /*
        The Action for the Transition from the Neutral state to the Attack state
        
        */
        public void Hit(Character Actor, Character Enemy, int Damage){
            //Debug.Log(Actor.gameObject.name + " Hit out of Neutral.");
            Actor.health -= Damage;
            Actor.stuntime = Enemy.Attack1.duration;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        /*
        The Action for the Transition from the Neutral state to the Attack state
        
        */
        public void Block(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

        /*
        The Action for the Transition from the Neutral state to the Attack state
        
        */
        public void Neutral(Character Actor) {
            //Debug.Log(Actor.gameObject.name + " Neutral is a special state only for Attack and Hit transitions.");
        }
    }
}