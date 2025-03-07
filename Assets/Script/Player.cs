using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int move;
    public float speed = 1.5f;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.check == false)
        {
            Move();
        }
    }

    public void Move()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -6.7f)
        {
            move = -1;
        }else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 6.7f)
        {
            move = 1;
        }else 
        { 
            move = 0; 
        }

        transform.Translate(Vector3.right*move*speed);
    }
}
