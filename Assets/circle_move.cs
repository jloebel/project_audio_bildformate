using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle_move : MonoBehaviour
{

    float timecounter = 0;
    float speed, width, height;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        width = 8;
    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime * speed;
        float x = Mathf.Cos(timecounter) * width;
        float y = 0.5f;
        float z = Mathf.Sin(timecounter) * width;

        transform.position = new Vector3(x + 25, y, z + 25);
    }
}
