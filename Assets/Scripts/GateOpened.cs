using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class GateOpened : MonoBehaviour
{
    
   
    CollisionHandler collisionHandler;
    public PlayableDirector playableDirector;
    
    void Start()
    {
        collisionHandler = FindObjectOfType<CollisionHandler>();
    }
    public  void Update()
    {
    playableDirector = GetComponent<PlayableDirector>();
    if(collisionHandler.keyClaimed == true){
    playableDirector.Play();
    }
    
      
    }
}//eyo if u are gonna ask me about this part of code eeehh.I really did this right by mistake XXDDD
 //but it works 100% XD
 
