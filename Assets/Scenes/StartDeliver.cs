using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StartDeliver : MonoBehaviour
{
    public GameObject startTarget;
    public GameObject spawnerTargetDeliver;
    public GameObject timerText;
    public GameObject refill;
    public Text scoreTextDisplay;
    public Text timeTextDisplay;
    public GameObject fuel;

    private int score = 0;
    private int timeTMP;
    public int JumlahPaket = 3;
    private int jumlahSudahDelivery = 0;
    private void OnCollisionEnter(Collision bike)
    {
        if(bike.collider.tag == "StartTargetTag")
        {
            Debug.Log("wow kena target start");
            // hilangkan starttarget tag
            startTarget.SetActive(false);

            // start timer 
            timerText.SetActive(true);
            // start acak posisi
            spawnerTargetDeliver.SetActive(true);
            
            
        }
        if (bike.collider.tag == "RefillFuelTag")
        {
            Debug.Log(" bensin = 100%");
            FuelLevel fuelObj = fuel.GetComponent("FuelLevel") as FuelLevel;
            fuelObj.fuelLevel = 100.0f;
            refill.SetActive(false);
        }
        if (jumlahSudahDelivery == JumlahPaket-1)
        {
            Debug.Log("bensin bonus");
            JumlahPaket += 5;
            FuelLevel fuelObj = fuel.GetComponent("FuelLevel") as FuelLevel;
            fuelObj.fuelLevel += 10.0f;
            refill.SetActive(true);

        }

        if (bike.collider.tag == "TargetDeliverTag")
        {
            
            timeTMP = Int32.Parse(timeTextDisplay.text);
            score += timeTMP * 5 / 2;


            timeTMP = timeTMP + 7;
            CountDownTimer timer = timeTextDisplay.GetComponent("CountDownTimer") as CountDownTimer;


            timer.countDownTimer = timeTMP;


            scoreTextDisplay.text = "Score : " + score.ToString();
            GameObject.FindGameObjectWithTag("TargetDeliverTag").SetActive(false);

           
            if (jumlahSudahDelivery < JumlahPaket-1)
            {
                //GameObject.FindGameObjectWithTag("TargetDeliverTag").SetActive(false);
                // matiin target deliver
                spawnerTargetDeliver.SetActive(false);
                
                spawnerTargetDeliver.SetActive(true);
                // acak lagi
                jumlahSudahDelivery++;
                Debug.Log("Paket telah Diantar sebanyak " + jumlahSudahDelivery);
            }

        }
       
    }
}
