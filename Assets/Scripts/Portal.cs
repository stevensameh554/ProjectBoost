using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
public Transform spawnPoint;

 Portal portal;
 bool teleported = false;
 void Start()
 {
   portal = GetComponent<Portal>();
 }
 void OnCollisionEnter(Collision other)
 {
    
    if(teleported == false)
    { 
        other.gameObject.transform.position = spawnPoint.position;
    
    }
    else
    {
        return;
    }
    teleported = true;
     
 }














}
