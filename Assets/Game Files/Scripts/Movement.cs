using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
   [SerializeField] ParticleSystem mainThrustParticle;
   [SerializeField] float mainThrust = 100f;
   [SerializeField] float rotateThrust = 100f;
   [SerializeField] AudioClip mainEngine;
   bool upok;
   bool left;
   bool right;
   
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
  
  
    public void pointerDownupok(){
        upok = true;
    }
    public void pointerUpupok(){
        upok = false;
    }

    public void gorightDown(){
        right = true;
    }
    public void gorigjtUp(){
        right = false;
    }

    public void goleftDown(){
        left = true;
    }
    public void goleftUp(){
        left = false;
    }





  void ProcessThrust()
  {
   //Going up
   if(Input.GetKey(KeyCode.Space) || upok == true)
        {
            StartThrusting();
        }
        else
        {
            StopThrusting();
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
       if (left == true){
           ApplyRotation(-rotateThrust);
       }
       if (right == true){
           ApplyRotation(rotateThrust);
       }
    }
    public void LeftRotation(){
        ApplyRotation(-rotateThrust);
    }
    public void RightRotation(){
        ApplyRotation(rotateThrust);
    }

   void ApplyRotation(float rotationThisFrame)
    {
        
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        
    }
    

}
  