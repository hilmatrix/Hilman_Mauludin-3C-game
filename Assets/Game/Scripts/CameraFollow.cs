using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    public float smoothSpeed = 5f;
    public Vector3 offset;

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
