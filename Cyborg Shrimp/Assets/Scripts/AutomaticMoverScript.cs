using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMoverScript : MonoBehaviour
{
    public float speed = 2.5f;
    public float x, y, z;
    public float moverX;
    public float moverY;

    // The way that I see this script being useful is for things such as cutscenes or scripted events where moving the character needs to occur w/out player control.
    void Update()
    {
        transform.Translate(x, y, z);
        x = speed * moverX * Time.deltaTime;
        y = speed * moverY * Time.deltaTime;
    }
}
