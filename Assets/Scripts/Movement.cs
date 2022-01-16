using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
   [SerializeField] ParticleSystem mainThrustParticle;
   [SerializeField] float mainThrust = 100f;
   [SerializeField] float rotateThrust = 100f;
   [SerializeField] AudioClip mainEngine;
   
   
   AudioSource audioSource;
   Rigidbody rb;
 
   
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        ProcessThrust();  
    }
    void FixedUpdate() 
    {
    ProcessRotation();
    }
  
  
  


  void ProcessThrust()
  {
   //Going up
   if(Input.GetKey(KeyCode.Space))
        {
            StartThrusting();
        }
        else
        {
            StopThrusting();
        }

    }

   

    void StartThrusting()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        if (audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(mainEngine);
        }
        if (!mainThrustParticle.isPlaying)
        {
            mainThrustParticle.Play();
        }
    }
    void StopThrusting()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
            mainThrustParticle.Stop();
        }
    }
   
  void ProcessRotation(){

     if(Input.GetKey(KeyCode.A))
        {
          ApplyRotation(-rotateThrust);

        }
        else if(Input.GetKey(KeyCode.D))
       {
          ApplyRotation(rotateThrust);

       }
    }

   void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;  
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; 
    }
    

}
  