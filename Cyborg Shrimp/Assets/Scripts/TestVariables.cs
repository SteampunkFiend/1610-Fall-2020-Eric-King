using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVariables : MonoBehaviour
{
  public float speed = 3f;
  public int scoreTest = 0;

  private void Update()
  {
    var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
    var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
    transform.Translate(hInput, vInput, 0);
  }
}
