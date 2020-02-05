using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{

    CharacterController cc;
    AudioSource audio;
    Transform trans;
    public AudioClip grass;
    public AudioClip hard;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        audio = GetComponent<AudioSource>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trans.position.x < 0)
        {
            audio.clip = hard;
        }
        else
        {
            audio.clip = grass;
        }
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && !audio.isPlaying)
        {
            audio.volume = Random.Range(0.3f, 0.5f);
            audio.pitch = Random.Range(0.9f, 1.1f);
            audio.Play();
        }
    }
}
