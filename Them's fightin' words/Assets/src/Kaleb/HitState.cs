using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class HitState : FightState {

        public void Move(Character Actor, int Direction) {
            Debug.Log("Can't move while hit.");
        }

        public void Attack(Character Actor, FightMove Atk) {
            Debug.Log("Can't attack while hit.");
        }

        public void Finish(Character Actor) {

        }
        
    }
}