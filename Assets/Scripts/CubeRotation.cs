using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float speed = 50.0f;
    private bool isRotating = false;

    void OnMouseDown() {
        isRotating = !isRotating;
    }

    void Update() {
        if (isRotating) {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }

}
