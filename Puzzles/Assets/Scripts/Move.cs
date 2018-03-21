using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

#region Variables
    private float Speed;

    private Rigidbody2D myrigidbody;
    private Vector2 Direction;
    public LevelManager levelManager;
  
[SerializeField]
    private Sprite[] RotationSprite;

    #endregion



#region Methods
    void Start()
    {


        myrigidbody = GetComponent<Rigidbody2D>();

        Speed = 200;
        setSprite(0);
      
    }



    void Update()
    {
        GetInput();

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
#endregion
}

