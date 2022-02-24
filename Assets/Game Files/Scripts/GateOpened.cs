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
        playableDirector = GetComponent<PlayableDirector>();
    }
    void Update()
    {
        MoveTheGate();

    }

    void MoveTheGate()
    {
        if (collisionHandler.keyClaimed == true)
        {
            playableDirector.Play();
        }
    }
}
 
