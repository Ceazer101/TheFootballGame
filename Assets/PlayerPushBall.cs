using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerPushBall : MonoBehaviour
{
    public float pushForce = 10.0f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody ballRigidbody = hit.collider.attachedRigidbody;

        if (ballRigidbody == null || ballRigidbody.isKinematic)
        {
            return;
        }

        if (hit.moveDirection.y < -0.3f)
        {
            return;
        }

        Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        ballRigidbody.velocity = pushDirection * pushForce;
    }
}
