using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float delay = 1f;
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.250f;

    // Update is called once per frame
    void Update()
    {
        Invoke("Camera", delay);
    }

    void Camera() {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;

        transform.LookAt(target);
    }
}
