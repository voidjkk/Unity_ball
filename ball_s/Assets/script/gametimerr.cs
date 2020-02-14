using UnityEngine;
using UnityEngine.UI; //用UI的東西記得這個
using System.Collections;
using System.Collections.Generic;


public class gametimerr : MonoBehaviour 
{
	
       public Text showtimer ; 
       public float elapsedtime ; //翻譯:流失的時間
       public float minute= 0 ;
	void Start () {
		
	}

	void Update () {
		
		elapsedtime += Time.deltaTime ; //計算經過的時間
		if (elapsedtime >= 60)  //進位
		{
		   minute++;
		   elapsedtime -= 60;   
		}
        showtimer.text = minute + ":" + elapsedtime.ToString("0.00") ; //顯示經過的時間
                   }
}

