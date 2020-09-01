using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 3f;
    public float x, y, z;
    
    void Start()
    {
        Debug.Log("Hello World!");
    }
    
    void Update()
    {
        x = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        y = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(x,y,z);
    }
}
