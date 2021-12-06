<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

namespace FightStatePattern {

/**
Handles actions taken during the transitions from the Attack State
**/
    public class AttackState : FightState {

        /*
        The Action for the Transition from the Attack state to the Move state
        In the Attack state, Characters can't move.
        */
        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            //Debug.Log("Can't move while attacking.");
        }

        /*
        The Action for the call to the Attack state while in the Attack state 
        In the attack state, Characters can't start another attack.
        */
        public Character Attack(Character Actor, FightMove Atk) {
            //Debug.Log("Can't attack again until the attack is done.");
            return null;
        }

        /*
        The Action for the the Transition from the Attack state to the Hit state
        If Characters are hit out of attacks, they move backwards while being hit.
        */
        public void Hit(Character Actor, Character Enemy, int Damage){
            //Debug.Log("Hit out of Attack.");
            Actor.health -= Damage;
            Actor.stuntime = Enemy.Attack1.duration;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        /*
        The Action for the the Transition from the Attack state to the Block state
        Characters can't block while they are attacking.
        */
        public void Block(Character Actor) {
            //Debug.Log("Can't block until the attack is done.");
        }

        /*
        The Action for the the Transition from the Attack state to the Neutral state
        Characters stop moving when they enter the Neutral phase
        */
        public void Neutral(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

    }
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class AttackState : FightState {

        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            Debug.Log("Can't move while attacking.");
        }

        public Character Attack(Character Actor, FightMove Atk) {
            Debug.Log("Can't attack again until the attack is done.");
            return null;
        }

        public void Hit(Character Actor, Character Enemy, int Damage){
            Debug.Log("Hit out of Attack.");
            Actor.health -= Damage;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        public void Block(Character Actor) {
            Debug.Log("Can't block until the attack is done.");
        }

        public void Neutral(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

    }
>>>>>>> 3cfdf465c3ae4c46e43bfb0c4fe0a5bd66381e66
}