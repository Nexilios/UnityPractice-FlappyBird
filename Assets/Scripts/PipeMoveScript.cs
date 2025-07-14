using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float deadZone = -50f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -deadZone)
        {
            Destroy(gameObject);
            return;
        }
        
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
    }
}
