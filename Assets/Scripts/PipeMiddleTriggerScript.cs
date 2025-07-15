using UnityEngine;

public class PipeMiddleTriggerScript : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Player")) return;
        
        gameManager.AddScore(1);
    }
}
