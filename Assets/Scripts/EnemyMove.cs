using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed; 
    
   

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + new Vector3(0, 0, speed) * Time.deltaTime;
    }
}
