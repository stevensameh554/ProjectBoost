using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] AudioClip crashSound;
    [SerializeField] AudioClip finishSound; 
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] ParticleSystem finishParticle; 

    GameObject goldKey;
    
    
    Rigidbody rb;
    Movement move;
    AudioSource audioSource;
    bool isTransitioning = false;
    bool colllisionDisabled = false;
    
    public bool keyClaimed = false;
    float delayInSeconds = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move = GetComponent<Movement>();
        audioSource = GetComponent<AudioSource>();
        
    }
    
    void Update() 
    {
     CheatKey();    
    }
    
    
    void OnCollisionEnter(Collision other)
    {
       if (isTransitioning || colllisionDisabled ){return;}
       
        switch(other.gameObject.tag )
        {
    case "Friendly":
        Debug.Log("u have hit a Friendly");
        break;
    case "Finish":
        
        FinishSequence();
        Debug.Log("WOWOWOWO U HAVE ENDED");
        break;
    
    
    
    
    default:
        CrashSequence();
        
        Debug.Log("Sorry U blew up :(");
        
        break;
        }
    }    
   void OnParticleCollision(GameObject other) 
   {
    
    Debug.Log("lol");
    CrashSequence();
   }
  public void CrashSequence()
   {
    
    isTransitioning = true;
    rb.freezeRotation = false;
    audioSource.Stop();
    audioSource.PlayOneShot(crashSound);
    crashParticle.Play();
    
    move.enabled = false;
    Invoke( "RelodLevel",delayInSeconds);
   }

  void FinishSequence()
   {
    Scene theValue = SceneManager.GetActiveScene();
    PlayerPrefs.SetString("userLevel", theValue.name);
   isTransitioning = true;
   audioSource.Stop();
   audioSource.PlayOneShot(finishSound);
   finishParticle.Play(); 
   rb.isKinematic = true;
   move.enabled = false;
   Invoke("NextLevel",delayInSeconds);
   }
   void RelodLevel()
   {
   //if u are a noob that happens
   int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
   SceneManager.LoadScene(currentSceneIndex);
   }

  void NextLevel()
  {
  //Loading Next level
   int currentSceneIndex =SceneManager.GetActiveScene().buildIndex;
   int nextSceneIndex = currentSceneIndex + 1;
   if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
   {
   nextSceneIndex = 0;
   }
   SceneManager.LoadScene(nextSceneIndex);

 }
 void CheatKey()
    {
     if(Input.GetKey(KeyCode.L))
     {
     NextLevel();

     }
     else if(Input.GetKeyDown(KeyCode.C))
     {
      Debug.Log("collisionDisabled");
      colllisionDisabled = !colllisionDisabled;

     }


    }
    
  
}