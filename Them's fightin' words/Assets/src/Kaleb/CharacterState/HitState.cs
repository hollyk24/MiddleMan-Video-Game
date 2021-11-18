using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class HitState : FightState {

        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            Debug.Log("Can't move while hit.");
        }

        public Character Attack(Character Actor, FightMove Atk) {
            Debug.Log("Can't attack while hit.");
            return null;
        }

        public void Hit(Character Actor, Character Enemy, int Damage) {
            Actor.health -= Damage;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        public void Block(Character Actor) {
            Debug.Log("Can't block while being hit.");
        }

        public void Neutral(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

    }
}