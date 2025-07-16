using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapStrength = 10f;
    public float ceilLimit = 17f;
    public float floorLimit = -17f;
    public Animator wingAnimator;
    
    [SerializeField]
    private GameManager gameManager;
    
    private Collider2D _birdCollider;
    
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        if (!birdRigidBody) return;
        _birdCollider = birdRigidBody.GetComponent<Collider2D>();
        
        if (wingAnimator) wingAnimator.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
    
    private void Update()
    {
        if (!gameManager) return;
        
        if (gameManager.isGameOver)
        {
            if (_birdCollider.enabled) _birdCollider.enabled = false;
            return;
        }
        
        if (transform.position.y > ceilLimit || transform.position.y < floorLimit)
        {
            gameManager.GameOver();
        }
        
        if (Input.GetKeyDown("space"))
        {
            birdRigidBody.linearVelocity = Vector2.up * flapStrength;

            if (!wingAnimator) return;
            wingAnimator.enabled = true;
            wingAnimator.Update(0f);
            wingAnimator.Play("Wing_Flap",0, 0f);
        }
    }
}
