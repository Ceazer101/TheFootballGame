using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float collisionForce = 20f;
    public Transform trans;
    public CharacterController characterController;
    public int movePerSec = 10;

    void Update()
    {
        Vector3 way = Vector3.zero;
        
        if(Input.GetKey(KeyCode.UpArrow)){
            way = Vector3.forward;
        } else if(Input.GetKey(KeyCode.DownArrow)){
            way = Vector3.back;
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            way = Vector3.left;
        } else if(Input.GetKey(KeyCode.RightArrow)){
            way = Vector3.right;
        }

        way = way * (Time.deltaTime * movePerSec);
        characterController.Move(way);
    }

      private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 force = collision.contacts[0].normal * -collisionForce;
            ballRb.AddForce(force, ForceMode.Impulse);
        }
    }
}