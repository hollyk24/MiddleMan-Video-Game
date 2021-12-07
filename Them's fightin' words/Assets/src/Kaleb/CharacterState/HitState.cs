using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

//use the state design pattern
namespace FightStatePattern {

/**
Handles actions taken during the transitions from the Hit State
**/
    public class HitState : FightState {

        /*
        The Action for the Transition from the Hit state to the Move state
        
        */
        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            //Debug.Log(Actor.gameObject.name + "Can't move while hit.");
        }
        
        /*
        The Action for the Transition from the Hit state to the Attack state
        
        */
        public Character Attack(Character Actor, FightMove Atk) {
            //Debug.Log(Actor.gameObject.name + "Can't attack while hit.");
            return null;
        }

        /*
        The Action for the Transition from the Hit state to the Hit state
        
        */
        public void Hit(Character Actor, Character Enemy, int Damage) {
            Actor.health -= Damage;
            Actor.stuntime = Enemy.Attack1.duration;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        /*
        The Action for the Transition from the Hit state to the Block state
        
        */
        public void Block(Character Actor) {
            Debug.Log(Actor.gameObject.name + "Can't block while being hit.");
        }

        /*
        The Action for the Transition from the Hit state to the Neutral state
        
        */
        public void Neutral(Character Actor) {
            Debug.Log(Actor.gameObject.name + " Reset to Neutral from Hit");
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

    }
}