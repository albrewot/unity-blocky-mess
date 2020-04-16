using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    //Atributes
    [SerializeField] public Rigidbody2D paddleRb;
    [SerializeField] public float minX;
    [SerializeField] public float maxX;
    [SerializeField] public float movementSpeed;
    [SerializeField] public float screenWidthInUnits;
    [SerializeField] public float mousePosInUnits;
    private Vector2 movement;
    private Vector2 paddlePos;

    //Methods

    public void CaptureInput() {
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    public void LimitPaddleMouseX() {
        paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
    }    
    public void LimitPaddleX() {
        paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(paddlePos.x, minX, maxX);
    }

    public void MovePaddle() {
        if(movement != Vector2.zero) {
            LimitPaddleX();
            paddleRb.MovePosition(paddlePos + movement.normalized * movementSpeed * Time.fixedDeltaTime);
        }
    }

    public void MovePaddleWithMouse() {
        mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        LimitPaddleMouseX();
        transform.position = paddlePos;
    }

    // Start is called before the first frame update
    void Start()
    {
        paddleRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CaptureInput();
    }

    private void FixedUpdate() {
        if(movement != Vector2.zero) {
            //MovePaddle();
        } else {
            MovePaddleWithMouse();
        }
    }
}
