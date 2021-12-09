using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightStatePattern;

namespace FightCharacter {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Character : MonoBehaviour
    {
        #region VARS

        //list of combat states: Move, Block, Attack, Hit
        public CharState combatState;

        public int health;//Stores the character health. If it goes to zero they lose.
        public float speed;//The speed that the character moves
        public int stuntime;//Stores the length of the hitstun inflicted by an enemy move
        public int BlockTimer;

        //The attached rigidbody
        public Rigidbody2D hurtbox;
        //References for external classes
        public Character enemy;
        public FGManager master;
        public FightMove Attack1;

        #endregion
        #region METHODS

        public Character(int hp, int spd, Character En) {
            speed = spd; 
            health = hp;
            combatState = new CharState();
            enemy = En;
        }

        public Character(Character En) {
            speed = 5; 
            health = 100;
            combatState = new CharState();
            enemy = En;
        }

        public Character() {
            speed = 5; 
            health = 100;
            combatState = new CharState();
        }

        void Start() {
            BlockTimer = 0;
            combatState = new CharState();
        }
        
        public Character Attack(FightMove Atk) {
            return combatState.Attack(this, Atk);
        }

        public void DefaultAttack() {
            Character HitPerson = combatState.Attack(this, Attack1);
            if(HitPerson != null) {
                HitPerson.Hit(this, Attack1.damage);
            }
        }

        public void Block() {
            combatState.Block(this);
        }

        public void Move(int direction) {
            combatState.Move(hurtbox, direction, speed);
        }

        public virtual void Hit(Character opponent, int damage) {
            Debug.Log("Regular Hit");
            combatState.Hit(this, opponent, damage);
        }
        #endregion
    }
}