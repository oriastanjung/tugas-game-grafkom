using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioEngine : MonoBehaviour
{
   public GameObject truck;
    AudioSource audioSource;
    public float minPitch = 0f;
    private float pitchFromCar;
    public float topSpeed = 120f;
    public float currentSpeed = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = minPitch;
    }
    void Update()
    {
        ThirdPersonMovement speed = truck.GetComponent("ThirdPersonMovement") as ThirdPersonMovement;
        currentSpeed = speed.speed/10000;
        pitchFromCar = currentSpeed / topSpeed;
        
        if (pitchFromCar < minPitch)
        {
            audioSource.pitch = minPitch;
            //audioSource.volume = 0;

        }
        else
        {
            audioSource.pitch = pitchFromCar;
            //audioSource.volume = 1;
        }
    }
}
