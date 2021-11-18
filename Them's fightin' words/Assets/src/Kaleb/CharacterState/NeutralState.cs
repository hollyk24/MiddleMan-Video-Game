using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class NeutralState : FightState {

        public void Move(Rigidbody2D Actor, int Direction, float Speed) {
            Debug.Log("Move out of Neutral.");
            if(Direction > 0) {
                Actor.velocity = new Vector2(Speed, 0);
            } else if(Direction < 0) {
                Actor.velocity = new Vector2(-Speed, 0);
            } else {
                Actor.velocity = new Vector2(0, 0);
            }
        }

        public Character Attack(Character Actor, FightMove Atk) {
            Debug.Log("Attack out of Neutral.");
            Actor.hurtbox.velocity = new Vector2(0, 0);
            return Atk.CallMove();
        }

        public void Hit(Character Actor, Character Enemy, int Damage){
            Debug.Log("Hit out of Neutral.");
            Actor.health -= Damage;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-10, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(10, 0);
            }
        }

        public void Block(Character Actor) {
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

        public void Neutral(Character Actor) {
            Debug.Log("Neutral is a special state only for Attack and Hit transitions.");
        }
    }
}