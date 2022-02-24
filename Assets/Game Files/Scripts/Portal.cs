using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
public Transform spawnPoint;

 
 bool teleported = false;

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
