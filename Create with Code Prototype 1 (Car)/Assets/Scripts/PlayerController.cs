using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //Moves the car in the forward and backwards directions based on vertical key input.
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        
        //Rotates/steers the car in the left and right directions based on horizontal key input.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
