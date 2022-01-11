using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
   MeshRenderer mesh;
   MeshCollider meshColl;
   void Start()
   {
    meshColl = GetComponent<MeshCollider>();
    mesh = GetComponent<MeshRenderer>();   
   }
   
   
   void OnCollisionEnter(Collision other)
   {
    if(other.gameObject.tag == "Player")
    {
     mesh.enabled = false;
     meshColl.isTrigger = true;

    }   
   }
}
