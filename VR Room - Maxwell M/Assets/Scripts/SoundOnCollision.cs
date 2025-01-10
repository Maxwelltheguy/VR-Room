using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
//Declare the variables
    [SerializeField] AudioClip soundToPlay;
    private AudioSource audioSource;
    private Rigidbody rb;
    [SerializeField] bool velocityVolume = false;
    [SerializeField] bool divideInstead = false;
    [SerializeField] float velocityMultiplier = 1.0f;

    private void Start()
    {
        //Set the audioSource and rb to a refrence on it's object
        audioSource = transform.GetComponent<AudioSource>();
        rb = transform.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (velocityVolume == false)
        {
            audioSource.clip = soundToPlay;
            audioSource.Play();
        }
        else
        {
            audioSource.clip = soundToPlay;
            audioSource.volume = rb.velocity.magnitude * velocityMultiplier;
            audioSource.Play();
        }
        
    }
}
