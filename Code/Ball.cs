using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
 {
     private Rigidbody rb;
     void Start()
     {
         rb = GetComponent<Rigidbody>();
     }
 
     void Update()
     {
         if (rb.IsSleeping())
         {
             rb.WakeUp();
         }
     }
 }
