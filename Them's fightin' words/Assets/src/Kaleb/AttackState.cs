using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class AttackState : FightState {

        public void Move(Character Actor, int Direction) {
            Debug.Log("Can't move while attacking.");
        }

        public void Attack(Character Actor, FightMove Atk) {
            Debug.Log("Can't attack until the attack is done.");
        }

        public void Finish(Character Actor){

        }
    }
}