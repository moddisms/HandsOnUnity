using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
  public static GameObject selected;

  public static float number = 1;

  void Update()
  {

      if (Input.GetMouseButtonDown(0))
      {

          Ray MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

          RaycastHit hit; // we are making a raycast 'hit' script that we can fill with info at a different point

// out hit = grabbing the value of 'hit' (currently empty) and changing 'hit', so when it changes to 'true' it also changes to 'hit'  
          bool click = Physics.Raycast(MouseRay, out hit);
          if (click == true)
          {
              print("I have hit an object");
              selected = hit.collider.gameObject;
          }
      }
  }
}
