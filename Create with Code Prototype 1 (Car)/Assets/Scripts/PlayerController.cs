using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        //Move the vehicle forward.
        print("Move the vehicle forward.");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed *horizontalInput);
    }
}
