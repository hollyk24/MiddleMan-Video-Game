using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the factory design pattern
namespace NPCFactoryPattern {

    public class MakeNPCMale : MonoBehaviour, NPCFramework {

        public void selectAvatar(int variation, float red, float green, float blue, GameObject NewNPC) {
            SpriteRenderer Avatar = NewNPC.GetComponent<SpriteRenderer>();
            if(Avatar == null) {
                return;
            }
            Avatar.color = new Color(red, green, blue);
            Sprite[] MaleSprites = Resources.LoadAll<Sprite>("Art/FG-Male");
            int TrueVari = variation%MaleSprites.Length;
            Avatar.sprite = MaleSprites[TrueVari];
        }
        
        public GameObject makeNPC(int variation, float red, float green, float blue, GameObject Premade) {
            GameObject NewNPC = Instantiate(Premade, new Vector3(0, 0, 0), Quaternion.identity);
            selectAvatar(variation, red, green, blue, NewNPC);
            return NewNPC;
        }
    }
}