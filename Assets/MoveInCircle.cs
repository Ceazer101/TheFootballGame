using UnityEngine;

public class MoveInCircle : MonoBehaviour
{
    public float speed = 1.0f;
    public float radius = 2.0f;
    public bool startMoving = true;
    private Vector3 centerPosition;
    private float angle;

    void Start()
    {
        centerPosition = transform.position;
    }

    void Update()
    {
        if (startMoving)
        {
            angle += speed * Time.deltaTime;

            float newX = centerPosition.x + Mathf.Cos(angle) * radius;
            float newZ = centerPosition.z + Mathf.Sin(angle) * radius;
            transform.position = new Vector3(newX, transform.position.y, newZ);
        }
    }
}
