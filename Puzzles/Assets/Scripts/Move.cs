using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{

#region Variables
    private float Speed;

    private Rigidbody2D myrigidbody;
    private Vector2 Direction;
    public LevelManager levelManager;
    private int health;
    private Vector2 StartPosition;
  
[SerializeField]
    private Sprite[] RotationSprite;

    #endregion



#region Methods
    void Start()
    {


        myrigidbody = GetComponent<Rigidbody2D>();

        Speed = 200;
        setSprite(0);
        health = 5;
        StartPosition = this.transform.position;
       
    }



    void Update()
    {
        GetInput();
        if(health == 0)
        {

            levelManager.LoadGameLevel("Lost");

        }

    }
    private void FixedUpdate()
    {
        move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
            levelManager.LoadGameLevel("Win");
    }



    void GetInput()
    {

        Direction = Vector2.zero;


        if (Input.GetKey(KeyCode.D))
        {
            Direction += Vector2.right;

            setSprite(1);
      
        }

        if (Input.GetKey(KeyCode.S))
        {
            Direction += Vector2.down;
            setSprite(4);

        }

        if (Input.GetKey(KeyCode.W))
        {
            Direction += Vector2.up;
            setSprite(3);

        }

        if (Input.GetKey(KeyCode.A))
        {
            Direction += Vector2.left;
            setSprite(2);
   

        }






    }
    private void move()
    {
        myrigidbody.velocity = (Direction.normalized * Speed);

    }
    

    private void setSprite(int index) {



        gameObject.GetComponent<SpriteRenderer>().sprite = RotationSprite[index];

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "arrow")
        {

            transform.position = StartPosition;

            health--;
            Debug.Log("u have: "+health.ToString());

           
        }
    }
    #endregion
}

