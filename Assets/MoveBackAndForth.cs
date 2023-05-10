using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public float speed = 1.0f;
    public float distance = 2.0f;
    public bool startMoving = true;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (startMoving)
        {
            float newPositionX = startPosition.x + Mathf.PingPong(Time.time * speed, distance * 2) - distance;
            transform.position = new Vector3(newPositionX, startPosition.y, startPosition.z);
        }
    }
}
