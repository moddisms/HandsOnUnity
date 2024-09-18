using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject prefab;

    // Update is called once per frame
 
   void Update()
    {
       if
           (Input.GetKeyDown(KeyCode.O))
      {
            Instantiate(prefab, transform.position, transform.rotation);
        }

   }
}
