using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{






    public float vel;
    private Vector2 veloc;
    public GameObject arrows;

    GameObject projectile;


    void Start()
    {
        projectile = Instantiate(arrows, arrows.transform.position, arrows.transform.rotation) as GameObject;
       


       




        veloc = (new Vector2(0, -vel));

    }



    private void FixedUpdate()
    {
      

        {


            if (projectile != null)
            {



                projectile.GetComponent<Rigidbody2D>().velocity = veloc;

            }



            else
            {
                projectile = Instantiate(arrows, arrows.transform.position, arrows.transform.rotation) as GameObject;


             



                }
            }
        }
        }


 



   

