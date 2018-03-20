using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    #region Variables


    [SerializeField]
    private Stats health;
    [SerializeField]
 
    #endregion

    #region Unity Metod

    private void Awake()
    {
        health.Initialize();
       
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentVal += 10;
          

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            health.CurrentVal -= 10;
          
        }

    }
  #endregion  
}
