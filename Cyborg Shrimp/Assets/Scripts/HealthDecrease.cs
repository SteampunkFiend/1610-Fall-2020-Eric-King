using System;
using UnityEngine;

public class HealthDecrease : MonoBehaviour
{

   public int Health1 = HealthPowerUp.Health;

   //This decrease script works and is based off of the static int in HealthPowerUp but doesn't grab the latest health value.
   public void OnTriggerEnter(Collider other)
   {
      Health1--;
      print(Health1);
   }
}
