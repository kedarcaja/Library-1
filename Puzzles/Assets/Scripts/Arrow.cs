using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{



    [SerializeField]
    private GameObject arrow;
    private Vector2 velocVect;
    [SerializeField]
    private float velY;
    [SerializeField]
    private float velX;
    [HideInInspector]
  public GameObject clone;

    private void Start()
    {
        velocVect = new Vector2(velX,-velY);
   
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

