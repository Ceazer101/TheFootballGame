using UnityEngine;

public class MoveSideToSide : MonoBehaviour
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
        float newPositionZ = startPosition.z + Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = new Vector3(startPosition.x, startPosition.y, newPositionZ);
    }
}
}
