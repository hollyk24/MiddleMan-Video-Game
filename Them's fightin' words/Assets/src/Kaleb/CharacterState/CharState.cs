using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

namespace FightStatePattern {

/**
Context Class
Handles the transitions between all states and return methods for information on the state machine.
**/
    public class CharState {

        public FightState CState {get; set;}

        /*
        Constructor for the char state
        */
        public CharState() {
            CState = new BlockState();
        }

        /*
        Return Method to check if the Character can move
        Currently the same as CanAttack, but as future states are added this might change.
        */
        public bool CanMove() {
            if(CState is MoveState || CState is BlockState || CState is NeutralState) {
                return true;
            }
            return false;
        }

        /*
        Return Method to check if the Character can Attack
        */
        public bool CanAttack() {
            if(CState is MoveState || CState is BlockState || CState is NeutralState) {
                return true;
            }
            return false;
        }

        public bool isHit() {
            if(CState is HitState) {
                return true;
            }
            return false;
        }

        public bool isAttacking() {
            if(CState is AttackState) {
                return true;
            }
            return false;
        }

        public void Move(Rigidbody2D Actor, int direction, float speed) {
            CState.Move(Actor, direction, speed);

            if(CState is BlockState || CState is NeutralState) {
                CState = new MoveState();
                if(Actor.gameObject.GetComponent<Animator>()!=null) {
                    Actor.gameObject.GetComponent<Animator>().Play("Player_Walk");
                }
                //Debug.Log("Switch to Move");
            }
        }

        public Character Attack(Character Actor, FightMove Atk, Sprite punchSprite) {
            Character HitPerson = CState.Attack(Actor, Atk);
            

            if(CState is MoveState || CState is BlockState || CState is NeutralState) {
                if(Actor.gameObject.GetComponent<Animator>()!=null) {
                    Actor.gameObject.GetComponent<Animator>().Play("Player_Punch");
                }

                CState = new AttackState();
                //Debug.Log("Switch to Attack");
            }
            return HitPerson;
        }

        public void Hit(Character Actor, Character Enemy, int Damage) {
            CState.Hit(Actor, Enemy, Damage);

            if(!(CState is BlockState)) {
                //Debug.Log(Actor.gameObject.name + " hit by " + Enemy.gameObject.name + " and not blocked");
                
                if(Actor.gameObject.GetComponent<Animator>()!=null) {
                    Actor.gameObject.GetComponent<Animator>().Play("Player_Hit");
                }
                CState = new HitState();
                //Debug.Log("Switch to Hit");
            }
        }

        public void Block(Character Actor) {
            CState.Block(Actor);

            if(CState is MoveState || CState is NeutralState) {
                if(Actor.gameObject.GetComponent<Animator>()!=null) {
                    if(CState is MoveState) { 
                        Debug.Log("Enter Block from Move");
                    }
                    if(CState is NeutralState) { 
                        Debug.Log("Enter Block from Neutral");
                    }
                    Debug.Log("Enter Idle via Block");
                    Actor.gameObject.GetComponent<Animator>().Play("Player_Idle");
                }

                CState = new BlockState();
                //Debug.Log("Switch to Block");
            }
        }

        public void Neutral(Character Actor, Sprite normalSprite) {
            CState.Neutral(Actor);
            
            if(CState is HitState || CState is AttackState) {
                if(Actor.gameObject.GetComponent<Animator>()!=null) {
                    Debug.Log("Enter Idle via Neutral");
                    Actor.gameObject.GetComponent<Animator>().Play("Player_Idle");
                }
                CState = new NeutralState();
                //Debug.Log("Switch to Neutral");
            }
        }

    }
}