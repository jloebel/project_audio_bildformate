using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    bool direction = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 30)
        {
            direction = true;
        }
        if (transform.position.z < -30)
        {
            direction = false;
            
        }
        if (direction)
            transform.position -= transform.forward * Time.deltaTime * 20;
        else
            transform.position += transform.forward * Time.deltaTime * 20;
    }
}
