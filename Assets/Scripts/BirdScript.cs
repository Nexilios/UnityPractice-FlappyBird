using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapStrength = 10f;
    
    [SerializeField]
    private GameManager gameManager;
    
    private Collider2D _birdCollider;
    
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        if (!birdRigidBody) return;
        _birdCollider = birdRigidBody.GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
    
    private void Update()
    {
        if (!gameManager) return;

        if (gameManager.isGameOver && _birdCollider.enabled)
        {
            _birdCollider.enabled = false;
        }
        
        if (Input.GetKeyDown("space") && !gameManager.isGameOver)
        {
            birdRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
