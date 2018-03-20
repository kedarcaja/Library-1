using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct : MonoBehaviour {
    private LevelManager lm;

	void Start () {
        lm = gameObject.GetComponentInParent<LevelManager>();
	}
	
	
	void Update () {
		
	}



    private void OnTriggerEnter2D(Collider2D collision)
    {


        Destroy(collision.gameObject);
        lm.LoadGameLevel("Lose");

    }

  
    
      
    }

