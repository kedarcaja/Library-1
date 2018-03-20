using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {


  


    public float targetTime = 10.0f;
    public float vel;
    private Vector2 veloc;
    public GameObject arrow;
    private GameObject projectile;
   
    void Start()
    {

      projectile = Instantiate(arrow, arrow.transform.position,arrow.transform.rotation) as GameObject;
        veloc = (new Vector2(0, -vel));

    }


    void Update()
    {


      

    }

    private void FixedUpdate()
    {



        if (projectile != null)
            projectile.GetComponent<Rigidbody2D>().velocity = veloc;
        else
            projectile = Instantiate(arrow, arrow.transform.position, arrow.transform.rotation) as GameObject;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

}