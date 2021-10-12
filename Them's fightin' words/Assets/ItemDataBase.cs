/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
 public List<Item> items = new List<Item>();

 private void Awake(){
     BuildDatabase();
 }

 public Item GetItem(int id){
     return items.Find(item => item.id == id);
 }

 public Item GetItem(string itemName){
     return items.Find(item => item.title == itemName);
 }

 void BuildDatabase(){
     items = new List<Item>() {
         newItem(0, "RocketLauncher", "A rocketlauncher weapon.", 
         new Dictionary<string, int>
         {
             {"Power", 15},
             {"Defence", 10}

         }) //, next item
     };
 }
}
*/
