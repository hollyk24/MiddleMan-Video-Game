<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

//use the state design pattern
namespace FightStatePattern {

/**
Handles actions taken during the transitions from the Block State
**/
    public class BlockState : FightState {

        /*
        The Action for the Transition from the Block state to the Move state
        
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
        The Action for the Transition from the Block state to the Attack state
        
        */
        public Character Attack(Character Actor, FightMove Atk) {
            Debug.Log("Attack out of Block.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
            return Atk.CallMove();
        }

        /*
        The Action for the Transition from the Block state to the Hit state
        
        */
        public void Hit(Character Actor, Character Enemy, int Damage){
            Debug.Log("Can't be hit while blocking.");
        }

        /*
        The Action for the Transition from the Block state to the Block state
        
        */
        public void Block(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

        /*
        The Action for the Transition from the Block state to the Neutral state
        
        */
        public void Neutral(Character Actor) {
            Debug.Log("Neutral is a special state only for Attack and Hit transitions.");
        }
    }
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class BlockState : FightState {

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
            Debug.Log("Attack out of Block.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
            return Atk.CallMove();
        }

        public void Hit(Character Actor, Character Enemy, int Damage){
            Debug.Log("Can't be hit while blocking.");
        }

        public void Block(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

        public void Neutral(Character Actor) {
            Debug.Log("Neutral is a special state only for Attack and Hit transitions.");
        }
    }
>>>>>>> 3cfdf465c3ae4c46e43bfb0c4fe0a5bd66381e66
}