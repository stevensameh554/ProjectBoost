using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
  [SerializeField]CollisionHandler keySeeker;
  GameObject goldKey;
  void Update()
  {
     goldKey = GameObject.Find("KeyGold");
  }
  public void OnTriggerEnter(Collider other)
  {
     if(other.gameObject.tag == "Player")
     {
      keySeeker.GetComponent<CollisionHandler>().keyClaimed = true;
      Destroy(goldKey);
      Debug.Log("The Player Hit The Key");

     }
  }
}//Tried to make the key collider a trigger But failed
