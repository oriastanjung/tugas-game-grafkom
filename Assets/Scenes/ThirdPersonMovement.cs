using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller; // controller component to use for move 
    public Transform cam;
    public float speed = 0f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
   
    public float maxSpeed = 80f;
   
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // -1 = 'a' , 1 = 'd'
        float vertical = Input.GetAxisRaw("Vertical"); // 1 = 'w' -1 = 's'
        //Debug.Log(vertical);
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (Input.GetKey(KeyCode.W))
        {   
            if(speed <= maxSpeed)
            {
                for (int i = 0; i < 1000; i++)
                {
                    speed += 0.0001f;
                }
                
            }
            //Debug.Log(speed);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (speed > 0f)
            {
                speed = 0;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (speed <= maxSpeed)
            {
                for (int i = 0; i < 1000; i++)
                {
                    speed += 0.00001f;
                }

            }
            //Debug.Log(speed);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (speed > 0f)
            {
                speed = 0f;
            }
        }


        if (direction.magnitude >= 0.1f && vertical != -1)
        {   
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity , turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
        if (direction.magnitude >= 0.1f && vertical == -1)
        {
            float targetAngle = Mathf.Atan2(direction.x, -direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(-moveDirection.normalized * speed * Time.deltaTime);
        }
    }
}
