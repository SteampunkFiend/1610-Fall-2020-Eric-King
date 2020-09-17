using System;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public static int Health = 100;
    
    //I tried to add something to make health increase in steps but this didn't work to plan.
    //public int HealthBoost = 15;
    
    public void OnTriggerEnter(Collider other)
    {
        Health++;
        print(Health);
    }
}
