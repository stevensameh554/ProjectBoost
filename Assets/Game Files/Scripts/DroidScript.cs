using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidScript : MonoBehaviour
{
    [SerializeField]Transform droid;
    Transform rocket;

    [Tooltip("If u want the Droid to follow the rocket")]
    [SerializeField]bool isStatic;

    CollisionHandler collisionHandler;
    void Start()
    {
        rocket = FindObjectOfType<CollisionHandler>().transform;
        collisionHandler = GetComponent<CollisionHandler>();
    }

   void Update()
   {
      
       if(isStatic == false){
       AimWeapon();
        
    }   
   }

   void AimWeapon()
   {
         droid.LookAt(rocket);
   }
}
