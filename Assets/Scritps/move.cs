using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour {  
  void Start () {
    
  }
    
  void Update () {
    Ray ray = new Ray(transform.position, transform.forward);
    RaycastHit hitInfo;
  
    if (Physics.Raycast(ray, out hitInfo)) {
        //what happens when intersected
    }else{
        //what happens when not intersected
     }
  }
  
  void Turn{
  
  }
  
  void straight{
  
  }
}
