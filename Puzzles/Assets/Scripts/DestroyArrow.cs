using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour {
   private GameObject toDestroy;

    private void Update()
    {
        toDestroy = GameObject.FindGameObjectWithTag("arrow");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {




        Destroy(toDestroy);

    }
}
