using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Attributes
    //Serialized
    [SerializeField] public Paddle paddle1;
    [SerializeField] public Rigidbody2D ballRb;
    [SerializeField] public Vector2 ballInitPos;
    [SerializeField] public Vector2 ballPush;

    //Non Serialized
    private Vector2 paddleToBallDistance;
    private bool hasStarted = false;

    //Methods
    public void StickBallToPaddle() {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallDistance;
    }

    public void LaunchBall() {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Launched");
            ballRb.velocity = new Vector2(ballPush.x, ballPush.y);
            hasStarted = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        transform.position = ballInitPos;
        paddleToBallDistance = transform.position - paddle1.transform.position;
    }



    // Update is called once per frame
    void Update()
    {
        if (!hasStarted) {
            StickBallToPaddle();
            LaunchBall();
        }
    }
}
