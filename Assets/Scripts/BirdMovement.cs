using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public bool birdIsAlive = true;

    public GameManagerScript gameManager;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if(transform.position.y > 17)
        {
            gameManager.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            gameManager.GameOver();
            birdIsAlive = false;
        }
    }
}
