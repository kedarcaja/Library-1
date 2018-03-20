using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour {
public AudioSource audi;
	public GameObject[] xStars;
	[SerializeField]
	private float MaxValue;
	[SerializeField]
	private int XPValue;
	[SerializeField]
	private float MinValue;
	[SerializeField]
	private int XpMax;
	public Text AchivmentStatus;
	private int starActivator= 0;


	void Awake() {

	xStars = GameObject.FindGameObjectsWithTag("fullStar");
	for(int i = 0;i<xStars.Length;i++)
	xStars[i].SetActive(false);

	MaxValue = 10;
	MinValue = 0;
	XPValue = 0;
	XpMax = 5;
	AchivmentStatus.text = "Completed: "+XPValue+"/"+XpMax;
		audi = GetComponent<AudioSource>();
		audi.Stop();

	
	}


	void Update ()
	{

		AchivmentStatus.text = "Completed: "+XPValue+"/"+XpMax;
	
		if (Input.GetKeyDown (KeyCode.A)) {
			MinValue += 1;
	
		}
		achivmentCalculate();

		
	}


	private bool AcivmentCompleted()
	{

		

	return XPValue ==XpMax;

	}




	private void achivmentCalculate ()
	{

		if (!AcivmentCompleted ()) {


			float difer = MaxValue - MinValue;

			
			if (difer == 0) {

				xStars [starActivator].SetActive (true);
				starActivator += 1;
				MaxValue += 5;
				MinValue = 0;
			
				XPValue += 1;

				audi.Play ();
				
			
			}
		
		


		} else {
			AchivmentStatus.text = "Achivment Completed";
		


		}
			
		}
		}
	









