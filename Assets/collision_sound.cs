using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_sound : MonoBehaviour
{
    AudioSource audio;
   
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "test")
        {
            Debug.Log("test");
            audio.Play();
        }
    }
}
