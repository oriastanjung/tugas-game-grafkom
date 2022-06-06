using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalArrow : MonoBehaviour
{
    [SerializeField]
    //private Transform target;
    
    private void Update()
    {
        Debug.Log(GameObject.FindGameObjectWithTag("TargetDeliverTag").transform.position);

        Vector3 targetPosition = GameObject.FindGameObjectWithTag("TargetDeliverTag").transform.position;
        targetPosition.y = transform.position.y;
        transform.LookAt(targetPosition);
    }
}
