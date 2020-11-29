using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    // volume 0 - 1
    //magnatude 
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "wall") {
            AudioSource[] myAudio = this.GetComponents<AudioSource>();
            myAudio[0].volume = other.relativeVelocity.magnitude / 20;
            myAudio[0].Play();
        }
       
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
