
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * jumpForce;
        float straffe = Input.GetAxis("Horizontal") * jumpForce;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0 );
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SPACE PRESSED");
            Vector3 atas = new Vector3(0, 100, 0);
            rb.AddForce(atas * jumpForce);
        }
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
