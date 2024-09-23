using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float moveSpeed = 25f;
        private void Update()
        {
            float moveVertical = Input.GetAxis("Vertical");
            float moveHorizontal = Input.GetAxis("Horizontal");

            Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.LookAt(newPosition + transform.position);
            transform.Translate(newPosition * moveSpeed * Time.deltaTime, Space.World);
        }
    
}
