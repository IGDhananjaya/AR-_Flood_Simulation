using UnityEngine;

public class somon : MonoBehaviour
{
    public float speed = 10f;
    public float maxMoveTime = 10f;

    private Vector3 initialLocalPosition;
    private float elapsedTime = 0f;
        private bool moving = false;

    void Start()
    {
        initialLocalPosition = transform.localPosition; // penting: local, bukan world
    }

    void Update()
    {
        if (moving)
        {
            float newX = transform.localPosition.x + (-speed * Time.deltaTime);
            transform.localPosition = new Vector3(newX, initialLocalPosition.y, initialLocalPosition.z);
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= maxMoveTime)
            {
                moving = false;
            }
        }
    }

    public void ResetMovement()
    {
        transform.localPosition = initialLocalPosition;
        elapsedTime = 0f;
        moving = false;
    }

    public void StartMovement()
    {
        ResetMovement();
        moving = true;
    }
}
