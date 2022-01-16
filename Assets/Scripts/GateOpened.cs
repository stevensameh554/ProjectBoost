using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class GateOpened : MonoBehaviour
{
    
   
    public CollisionHandler keySeeker;
    public PlayableDirector playableDirector;
    
    public  void Update()
    {
        
    playableDirector = GetComponent<PlayableDirector>();
    
     if(keySeeker.GetComponent<CollisionHandler>().keyClaimed == true)
     {
     playableDirector.Play();
     
     }
      
    }
}//i really did this right by mistake XXDDD
