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

        public bool CanMove() {
            if(CState is MoveState || CState is BlockState || CState is NeutralState) {
                return true;
            }
            return false;
        }

        public bool CanAttack() {
            if(CState is MoveState || CState is BlockState || CState is NeutralState) {
                return true;
            }
            return false;
        }

        public void Move(Rigidbody2D Actor, int direction, float speed) {
            CState.Move(Actor, direction, speed);

            if(CState is BlockState || CState is NeutralState) {
                CState = new MoveState();
                Debug.Log("Switch to Move");
            }
        }

        public Character Attack(Character Actor, FightMove Atk, Sprite punchSprite) {
            Character HitPerson = CState.Attack(Actor, Atk);
            

            if(CState is MoveState || CState is BlockState || CState is NeutralState) {
                
                SpriteRenderer Avatar = Actor.gameObject.GetComponent<SpriteRenderer>();
                if(Avatar != null) {
                    Avatar.sprite = punchSprite;
                }

                CState = new AttackState();
                Debug.Log("Switch to Attack");
            }
            return HitPerson;
        }

        public void Hit(Character Actor, Character Enemy, int Damage) {
            CState.Hit(Actor, Enemy, Damage);

            if(!(CState is BlockState)) {
                CState = new HitState();
                Debug.Log("Switch to Hit");
                Actor.stuntime = Enemy.Attack1.duration;
            }
        }

        public void Block(Character Actor) {
            CState.Block(Actor);

            if(CState is MoveState || CState is NeutralState) {
                CState = new BlockState();
                Debug.Log("Switch to Block");
            }
        }

        public void Neutral(Character Actor, Sprite normalSprite) {
            CState.Neutral(Actor);
            
            if(CState is HitState || CState is AttackState) {
                Actor.gameObject.GetComponent<SpriteRenderer>().sprite = normalSprite;

                CState = new NeutralState();
                Debug.Log("Switch to Neutral");
            }
        }

    }
}