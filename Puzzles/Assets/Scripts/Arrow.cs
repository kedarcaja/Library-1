using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{



    [SerializeField]
    private GameObject arrow;
    private Vector2 velocVect;
    [SerializeField]
    private float vel;
  public GameObject clone;

    private void Start()
    {
        velocVect = new Vector2(0,-vel);
   
    }
    private void FixedUpdate()
    {


        if (clone != null)
            clone.GetComponent<Rigidbody2D>().velocity = velocVect;

        else
            getClone();

        }
    



    private void getClone()
    {


        clone = Instantiate(arrow, arrow.transform.position, arrow.transform.rotation);

    }
    }

