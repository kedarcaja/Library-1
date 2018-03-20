using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{







    public GameObject doors;



    void Start()
    {

    }


    void Update()
    {

        
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {


        doors.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {


        doors.SetActive(true);
    }

    
}
    
