using UnityEngine;

public class PipeMiddleTrigger : MonoBehaviour
{
    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            gameManager.AddScore(1);
        }
    }
}
