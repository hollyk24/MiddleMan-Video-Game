using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use the factory design pattern
namespace NPCFactoryPattern  {

    public interface NPCFramework {

        void selectAvatar(int variation, float red, float green, float blue, GameObject NewNPC);
        
        GameObject makeNPC(int variation, float red, float green, float blue, GameObject Premade);
    }
}