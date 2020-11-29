using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed;

    void Start() {
        AudioSource[] myAudio = this.GetComponents<AudioSource>();
        myAudio[1].volume = 0;
        myAudio[1].Play();
    }
   
    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        Rigidbody body = GetComponent<Rigidbody>();
        body.AddForce(new Vector3(xAxis, 0, yAxis));
        AudioSource[] myAudio = this.GetComponents<AudioSource>();
        myAudio[1].volume = GetComponent<Rigidbody>().velocity.magnitude / 20;
    }
}
