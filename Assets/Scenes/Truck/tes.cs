using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tes : MonoBehaviour
{
    public GameObject truck;
    AudioSource audioSource;
    public float topSpeed = 120f;
    public float currentSpeed = 0;
    public float pitch = 0;

    void Update()
    {
        ThirdPersonMovement truckObj = truck.GetComponent("ThirdPersonMovement") as ThirdPersonMovement;
        currentSpeed = truckObj.speed;
        pitch = currentSpeed / topSpeed;
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = pitch;
    }
}