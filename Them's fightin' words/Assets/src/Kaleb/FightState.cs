using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public interface FightState {

        void Move(Character Actor, int Direction);

        void Attack(Character Actor, FightMove Atk);

        void Finish(Character Actor);
    }
}