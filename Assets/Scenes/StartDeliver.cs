using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDeliver : MonoBehaviour
{
    public GameObject startTarget;
    public GameObject spawnerTargetDeliver;

    public int JumlahPaket = 1;
    private int jumlahSudahDelivery = 0;
    private void OnCollisionEnter(Collision bike)
    {
        if(bike.collider.tag == "StartTargetTag")
        {
            Debug.Log("wow kena target start");
            // hilangkan starttarget tag
            startTarget.SetActive(false);

            // start timer 

            // start acak posisi
            spawnerTargetDeliver.SetActive(true);
         
        }
        if (bike.collider.tag == "TargetDeliverTag")
        {
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
