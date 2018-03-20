using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NUnit.Framework.Constraints;


public class SwitchungNumber : MonoBehaviour {

	#region variables
	public Image[] images;
	public Sprite[] NumberSprite;
	Image image1;
	Image image2;
	Image image3;


	int indexImage1;
	int indexImage2;
	int indexImage3;
    bool currentCombination;
  public   GameObject ContinueBoard;
	#endregion


	#region Methods
	void Awake(){

		indexImage1 = 0;
		indexImage2 = 0;
		indexImage3 = 0;
		image1 = images [0];
		image2 = images [1];
		image3 = images [2];
		image1.sprite = NumberSprite [indexImage1];
		image2.sprite = NumberSprite [indexImage2];

		image3.sprite = NumberSprite [indexImage3];

        currentCombination = false;
		image1.color = Color.white;
		image2.color = Color.white;
		image3.color = Color.white;
        ContinueBoard.SetActive(false);

	}



	public void OnButtonNextClick( Image image){
		
		if (image == image1) {
			indexImage1++;
			if (indexImage1 > NumberSprite.Length - 1)
				indexImage1 = 0;

			image1.sprite = NumberSprite [indexImage1];
		
		}
			if (image == image2) {
			indexImage2++;
			if (indexImage2 > NumberSprite.Length - 1)
				indexImage2 = 0;
			image2.sprite = NumberSprite [indexImage2];


		}
		 if (image == image3) {
			indexImage3++;
			if (indexImage3 > NumberSprite.Length - 1)
				indexImage3 = 0;
			image3.sprite = NumberSprite [indexImage3];


		}
         

	
	
	}
    private void Update()
    {


        if (Unlocked())
        {
            print("Unlocked");
            ContinueBoard.SetActive(true);
        }
        else
        {
            print("locked");

            ContinueBoard.SetActive(false);
        }

    }
    public void OnButtonPreviewClick( Image image){

		if (image == image1) {
			indexImage1--;
			if (indexImage1 < 0)
				indexImage1 = 5;

			image1.sprite = NumberSprite [indexImage1];

		}
		if (image == image2) {
			indexImage2--;
			if (indexImage2 <0)
				indexImage2 = 5;
			image2.sprite = NumberSprite [indexImage2];


		}
		if (image == image3) {
			indexImage3--;
			if (indexImage3 <0)
				indexImage3 = 5;
			image3.sprite = NumberSprite [indexImage3];


		}




	}


    bool Unlocked() {

       
        return indexImage1 == 0&&indexImage2==1&&indexImage3 == 2;


    }





}
#endregion
