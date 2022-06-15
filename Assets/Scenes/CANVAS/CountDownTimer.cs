using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour{
    public int countDownTimer;
    public Text countDownDisplay;
    public GameObject panelTimeOut;
    public GameObject bike;
    public GameObject mainCamera;
    public Text fuelLevel;
    public GameObject fuelBG;
    public GameObject fuel;
    public GameObject backToMenuBtn;
    public GameObject sound;

    private void Start()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown() {
        while (countDownTimer > 0) {

            countDownDisplay.text = countDownTimer.ToString();
            yield return new WaitForSeconds(1f);
            countDownTimer--;

        }
            

        countDownDisplay.text = "TIMEOUT";
            yield return new WaitForSeconds(1f);
            countDownDisplay.gameObject.SetActive(false);
            panelTimeOut.SetActive(true);
            bike.SetActive(false);
            mainCamera.SetActive(false);
            fuelLevel.gameObject.SetActive(false);
            fuelBG.SetActive(false);
            backToMenuBtn.SetActive(true);
            sound.SetActive(false);

    }

      
     
}