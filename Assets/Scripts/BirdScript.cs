using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapStrength = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            birdRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
