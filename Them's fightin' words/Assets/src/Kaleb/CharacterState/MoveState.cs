<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

//use the state design pattern
namespace FightStatePattern {

/**
Handles actions taken during the transitions from the Move State
**/
    public class MoveState : FightState {

        /*
        The Action for the Transition from the Move state to the Move state
        
        */
        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            if(Direction > 0) {
                Actor.velocity = new Vector2(Speed, 0);
            } else if(Direction < 0) {
                Actor.velocity = new Vector2(-Speed, 0);
            } else {
                Actor.velocity = new Vector2(0, 0);
            }

        }

        /*
        The Action for the Transition from the Move state to the Attack state
        
        */
        public Character Attack(Character Actor, FightMove Atk) {
            //Debug.Log(Actor.gameObject.name + " Attack out of Move.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
            return Atk.CallMove();
        }

        /*
        The Action for the Transition from the Move state to the Hit state
        
        */
        public void Hit(Character Actor, Character Enemy, int Damage) {
            //Debug.Log(Actor.gameObject.name + " Hit out of Move.");
            Actor.health -= Damage;
            Actor.stuntime = Enemy.Attack1.duration;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        /*
        The Action for the Transition from the Move state to the Block state
        
        */
        public void Block(Character Actor) {
            //Debug.Log(Actor.gameObject.name + " Block out of Move.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

        /*
        The Action for the Transition from the Move state to the Neutral state
        
        */
        public void Neutral(Character Actor) {
            //Debug.Log("Neutral is a special state only for Attack and Hit transitions.");
        }
    }
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class MoveState : FightState {

        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            if(Direction > 0) {
                Actor.velocity = new Vector2(Speed, 0);
            } else if(Direction < 0) {
                Actor.velocity = new Vector2(-Speed, 0);
            } else {
                Actor.velocity = new Vector2(0, 0);
            }

        }

        public Character Attack(Character Actor, FightMove Atk) {
            Debug.Log("Attack out of Move.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
            return Atk.CallMove();
        }

        public void Hit(Character Actor, Character Enemy, int Damage) {
            Debug.Log("Hit out of Move.");
            Actor.health -= Damage;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        public void Block(Character Actor) {
            Debug.Log("Block out of Move.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

        public void Neutral(Character Actor) {
            Debug.Log("Neutral is a special state only for Attack and Hit transitions.");
        }
    }
>>>>>>> 3cfdf465c3ae4c46e43bfb0c4fe0a5bd66381e66
}