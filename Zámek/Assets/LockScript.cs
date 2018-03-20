using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockScript : MonoBehaviour {
    #region Varibles
    [SerializeField]
    private Sprite[] number;

    [SerializeField]
    private Image image;
    int min, max;
    private int index;

    public  int currentIndex;
    private AudioSource audsrc;
    private int x;
    private Button btn;
    public GameObject Continue;
	public int continueValue;
    public int Index


    {
        get
        {
            return index;
        }

        set
        {
            index = value;
        }
    }
    #endregion

    #region Unity methods

    void Start() {
        min = 0;
        max = 6;
		continueValue = 0;
      
        print(currentIndex);
    }


    void Update()
    {
        image.sprite = number[Index];
       
      

    }







    public void Previous()
    {
       
        
            if (Index == min)
            {
                Index = max;
            }
            Index -= 1;
            if (Index == currentIndex)
            {
                print("succse");

              
                print(Index);
                Index = currentIndex;
            
        }
    }

   public  void Next()
   {
        
            if (Index == max)
            {
                Index = min;
            }
            Index += 1;
		if (Unlocked())
            {
                print(Index);
               
                Index = currentIndex;

            
        }

      
    }

    private bool Unlocked()
    {

		return index == currentIndex;  


    }


public	void onContinueClick(){
		if (Unlocked ()) {



			continueValue += 1;
		

		}
			

	}
   
   #endregion
}
