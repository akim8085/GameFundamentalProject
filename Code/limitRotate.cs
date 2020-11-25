using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitRotate : MonoBehaviour {
 
  public float rotateSpeed;
   
  public float minimumX;
  public float maximumX;
 
  public float minimumY;
  public float maximumY;
 
  float rotationX = 0F;
  float rotationY = 0F;
   
   
   // Use this for initialization
  void Start ()
  {
   
  }
   
  public static float ClampAngle (float angle, float min, float max)
  {
    if (angle < -360F) angle += 360F;
    if (angle > 360F) angle -= 360F;
     
    return Mathf.Clamp (angle, min, max);
       
  }
   
 
  void Update ()
  {
     
    rotationY += Input.GetAxis("Vertical") * rotateSpeed * Time.deltaTime;
    rotationY = ClampAngle (rotationY, minimumY, maximumY);
         
    rotationX+= -Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
    rotationX = ClampAngle (rotationX, minimumX, maximumX);
         
                   
    Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, Vector3.right);
    Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.forward);
    transform.rotation=   yQuaternion * xQuaternion;
 
   }
}    