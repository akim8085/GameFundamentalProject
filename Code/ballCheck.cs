using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCheck : MonoBehaviour
{
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trap") {
            other.gameObject.SetActive(false);
            Time.timeScale = 0;

        }
    }
}
