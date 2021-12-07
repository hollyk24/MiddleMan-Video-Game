using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

//use the state design pattern
namespace FightStatePattern {

/**
Handles actions taken during the transitions from the Attack State
**/
    public interface FightState {

        void Move(Rigidbody2D Actor, int Direction, float Speed);

        Character Attack(Character Actor, FightMove Atk);

        void Hit(Character Actor, Character Enemy, int Damage);

        void Block(Character Actor);

        void Neutral(Character Actor);
    }
}