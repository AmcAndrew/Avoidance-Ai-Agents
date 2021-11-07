using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour{
    [Header ("View")]
    float viewDistance = 5f;
    public float viewRadius;
    public GameObject viewDirection;
    private float idx;

    [Header ("Movement")]
    float movementSpeed = 5f;
    float rotateSpeed = 20f;
    float obsticalDistance;

    void Update (){
        checkCollitions();
    }

    void checkCollitions(){
        idx ++;
        viewDirection.transform.localRotation = Quaternion.Euler(0, Mathf.Sin(idx) * viewRadius, 0);

        Ray ray = new Ray(transform.position, viewDirection.transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, viewDistance)) {
            //what happens when intersected
            Debug.DrawLine (ray.origin, hitInfo.point, Color.red);
            Turn(viewDirection);
        }else{
            //what happens when not intersected
            Debug.DrawLine (ray.origin, ray.origin + ray.direction * viewDistance, Color.green);           
            Straight();
        }

    }

    void Turn(GameObject obsticalAngle){

        // if (Random.Range(0, 3) == 1){
        if (obsticalAngle.transform.localRotation.y < 0){
            transform.Rotate(0f, rotateSpeed, 0f, Space.Self);
        }else{
            transform.Rotate(0f, rotateSpeed * -1, 0f, Space.Self);
        }

        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }

    void Straight(){
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
}
