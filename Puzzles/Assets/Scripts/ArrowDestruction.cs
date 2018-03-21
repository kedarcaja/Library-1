using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDestruction : MonoBehaviour {








    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Arrow hited");
        Destroy(gameObject);
    }
}
