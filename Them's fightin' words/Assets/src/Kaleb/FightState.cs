using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the state design pattern
namespace FightStatePattern {

    public interface FightState {

        void Move(Rigidbody2D Actor, int Direction, int Speed);

        void Attack(Character Actor, FightMove Atk);

        void Hit(Character Actor, Character Enemy, int Damage);

        void Block(Character Actor);

        void Neutral(Character Actor);
    }
}