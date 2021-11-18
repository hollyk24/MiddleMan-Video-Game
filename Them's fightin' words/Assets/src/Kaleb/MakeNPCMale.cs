using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the factory design pattern
namespace NPCFactoryPattern {

    public class MakeNPCMale {

        public void selectAvatar(int variation, float red, float green, float blue, GameObject NewNPC) {
            SpriteRenderer Avatar = NewNPC.GetComponent<SpriteRenderer>();
            if(Avatar == null) {
                return;
            }
            Avatar.color = new Color(red, green, blue);
            Sprite[] MaleSprites = Resources.LoadAll("Art/FG-Male", typeOf(Sprite));
            int TrueVari = variation%MaleSprite.Length;
            Avatar.sprite = MaleSprites[TrueVari];
        }
        
        public GameObject makeNPC(int variation, float red, float green, float blue, GameObject Premade) {
            GameObject NewNPC = Instantiate(Premade, new Vector3(0, 0, 0))
            selectAvatar(variation, red, green, blue, NewNPC);
            return NewNPC;
        }
    }
}