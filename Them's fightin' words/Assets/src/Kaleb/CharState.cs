using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {
    public class CharState {

        public FightState CState {get; set;}

        public CharState() {
            CState = new BlockState();
        }

        public void Move(Rigidbody2D Actor, int direction, int speed) {
            CState.Move(Actor, direction, speed);

            if(CState is BlockState || CState is NeutralState) {
                CState = new MoveState();
                Debug.Log("Switch to Move");
            }
        }

        public void Attack(Character Actor, FightMove Atk) {
            CState.Attack(Actor, Atk);

            if(CState is MoveState || CState is BlockState || CState is NeutralState) {
                CState = new AttackState();
                Debug.Log("Switch to Attack");
            }
        }

        public void Hit(Character Actor, Character Enemy, int Damage) {
            CState.Hit(Actor, Enemy, Damage);

            if(!(CState is BlockState)) {
                CState = new HitState();
                Debug.Log("Switch to Hit");
            }
        }

        public void Block(Character Actor) {
            CState.Block(Actor);

            if(CState is MoveState || CState is NeutralState) {
                CState = new BlockState();
                Debug.Log("Switch to Block");
            }
        }

        public void Neutral(Character Actor) {
            CState.Neutral(Actor);

            if(CState is HitState || CState is AttackState) {
                CState = new NeutralState();
                Debug.Log("Switch to Neutral");
            }
        }

    }
}