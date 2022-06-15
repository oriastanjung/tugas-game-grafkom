using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FuelLevel : MonoBehaviour
{
    public float fuelLevel;
    public Text fuelLevelDisplay;
    public int fuel;
    // Update is called once per frame

    public Text countDownDisplay;
    public GameObject panelTimeOut;
    public GameObject bike;
    public GameObject mainCamera;
    public GameObject backToMenuBtn;
    public GameObject sound;

    public GameObject fuelBG;


    void Update()
    {
        fuel = (int)fuelLevel;
        fuelLevelDisplay.text ="Fuel = " + fuel.ToString() + "%";

        if (fuel <= 0)
        {
            countDownDisplay.gameObject.SetActive(false);
            panelTimeOut.SetActive(true);
            bike.SetActive(false);
            mainCamera.SetActive(false);
            gameObject.SetActive(false);
            fuelBG.SetActive(false);
            backToMenuBtn.SetActive(true);
            sound.SetActive(false);
        }
    }
}
