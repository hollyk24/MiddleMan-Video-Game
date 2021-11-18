using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class NeutralState : FightState {

        public void Move(Rigidbody2D Actor, int Direction, int Speed) {
            if(Direction > 0) {
                Actor.velocity = new Vector2(Speed, 0);
            } else if(Direction < 0) {
                Actor.velocity = new Vector2(-Speed, 0);
            } else {
                Actor.velocity = new Vector2(0, 0);
            }
        }

        public void Attack(Character Actor, FightMove Atk) {
            Atk.CallMove();
            Actor.hurtbox.velocity = new Vector2(0, 0);
        }

        public void Hit(Character Actor, Character Enemy, int Damage){
            Actor.health -= Damage;
            if(Enemy.hurtbox.position.x > Actor.hurtbox.position.x) {
                Actor.hurtbox.velocity = new Vector2(-2, 0);
            } else {
                Actor.hurtbox.velocity = new Vector2(2, 0);
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