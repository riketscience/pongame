using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{

    bool gameRunning = false;

    GameObject ball;
    public GameObject paddleTop;
    public GameObject paddleBottom;

    public float ballspeed;
    public GameObject ballPrefab ;
    
    Rigidbody ballRigidbody;
    GameObject paddleToAttachTo;

    // Use this for initialization
    void Start()
    {
        paddleToAttachTo = paddleBottom;
        SpawnBall();
    }

    void SpawnBall()
    {
        var yAdjust = paddleToAttachTo.name == "Paddle Bottom" ? 3 : -3;
        ball = Instantiate(ballPrefab, paddleToAttachTo.transform.position + new Vector3(0, yAdjust, 0), Quaternion.identity) as GameObject;
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameRunning)
        {
            var initialPlacement = paddleToAttachTo.name == "Paddle Bottom" ? 2 : -2;
            ballRigidbody.position = paddleToAttachTo.transform.position + new Vector3(0, initialPlacement, 0);

            if (Input.GetButtonDown("Jump"))
            {             
                var initialDirection = paddleToAttachTo.name == "Paddle Bottom" ? 1 : -1;
                gameRunning = true;
                ballRigidbody.isKinematic = false;
                ballRigidbody.velocity = new Vector3(0, initialDirection*ballspeed, 0);
            }
        }

        if (ballRigidbody.position.y < -11 || ballRigidbody.position.y > 12)
        {
            gameRunning = false;
            paddleToAttachTo = ballRigidbody.position.y < -11 ? paddleBottom : paddleTop;
        }
    }
}
