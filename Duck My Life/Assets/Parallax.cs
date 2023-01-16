using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera cam;
    public Transform subject;

    // startPosition will be saved as a Vector2 so it only keeps x and y
    Vector2 startPosition;
    float startZ;

    // the => means that it will be calculated everytime we call this function. We treat it as a variable, cannot be written, only read.
    // travel calculates how far the camera has moved compared to the start position.
    Vector2 travel => (Vector2)cam.transform.position - startPosition;
    Vector2 parallaxFactor;

    public void Start() {
        startPosition = transform.position;
        // This will keep the starting value of Z
        startZ = transform.position.z;
    }

    public void Update(){
        transform.position = startPosition + travel;
    }

}
