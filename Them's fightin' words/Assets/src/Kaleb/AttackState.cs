using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class AttackState : FightState {

        public void Move(Rigidbody2D Actor, int Direction, int Speed) {
            Debug.Log("Can't move while attacking.");
        }

        public void Attack(Character Actor, FightMove Atk) {
            Debug.Log("Can't attack again until the attack is done.");
        }

        public void Hit(Character Actor, Character Enemy, int Damage){
            Debug.Log("Hit out of Attack.");
            Actor.health -= Damage;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-2, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(2, 0);
            }
        }

        public void Block(Character Actor) {
            Debug.Log("Can't block until the attack is done.");
        }

        public void Neutral(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

    }
}