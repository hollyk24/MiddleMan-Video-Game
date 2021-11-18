using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public class MoveState : FightState {

        public void Move(Character Actor, int Direction) {

        }

        public void Attack(Character Actor, FightMove Atk) {
                Atk.CallMove();
        }

        public void Finish(Character Actor) {

        }

    }
}