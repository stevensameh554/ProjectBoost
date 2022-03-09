using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
   
   
   [SerializeField] ParticleSystem mainThrustParticle;
   [SerializeField] float mainThrust = 100f;
   [SerializeField] float rotateThrust = 100f;
   [SerializeField] AudioClip mainEngine;

   private int thrustValue;
   private int rotateValue;

   

   AudioSource audioSource;
   Rigidbody rb;
 
   
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        ThrustPhone();
    }

    
    void FixedUpdate()
    {
        ProcessRotate();
    }
    private void ThrustPhone()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * thrustValue * Time.deltaTime);
         
    }

    private void ProcessRotate()
    {
        transform.Rotate(Vector3.forward * rotateValue * rotateThrust * Time.deltaTime);
    }




    void ProcessThrust()
    {
        //Going up
        if (Input.GetKey(KeyCode.Space))
        {
            StartThrusting();
        }
        else
        {
            StopSoundFX();
        }

    }

   

    public void StartThrusting()
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
    public void StopSoundFX()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
            mainThrustParticle.Stop();
        }
    }
   
    // public void ProcessRotation(){

     
     
    //  if(Input.GetKey(KeyCode.A))
    //     {
    //       ApplyRotation(rotateThrust);

    //     }
    //     else if(Input.GetKey(KeyCode.D))
    //    {
    //       ApplyRotation(-rotateThrust);

    //    }
    // }

    public void ApplyRotation(int value)
    {
        
        rotateValue = value;
        
    }
    public void ApplyThrust(int value)
    {
        thrustValue = value;
    }
    public void PlaySoundFX()
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(mainEngine);
        }
        if (!mainThrustParticle.isPlaying)
        {
            mainThrustParticle.Play();
        }
    }

}
  