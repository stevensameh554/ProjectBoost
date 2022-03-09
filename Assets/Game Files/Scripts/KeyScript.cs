using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
 GameObject goldKey;
 CollisionHandler collisionHandler;
 


 void Start()
 {
    collisionHandler = FindObjectOfType<CollisionHandler>();
    goldKey = GameObject.Find("pPlane3");
 }
 
 void OnCollisionEnter(Collision other)
 {
   if(other.gameObject.tag == "Player")
   {
    collisionHandler.keyClaimed = true;
    DestroyObject(goldKey);
    Debug.Log("LOL KEY");
   }
 }

}
//Tried to make the key collider a trigger But failed
