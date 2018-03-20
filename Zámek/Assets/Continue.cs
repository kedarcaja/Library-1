using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour {

	public LockScript[] ls;

    private void Start()
    {
        print("locked");
    }
    void Update () {
		if (ls [0].continueValue == 1 && ls [1].continueValue == 1 && ls [2].continueValue == 1)
			print ("Unlocked");
	
		
	}
}
