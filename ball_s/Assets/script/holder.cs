using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holder : MonoBehaviour {
	

	
     void OnTriggerEnter(Collider ball)
	{
		if(ball.gameObject.tag == "Player" )
		{   
	    ball.transform.parent   =  this.transform ;
		Debug.Log("enter");

		}
	}
	
	 void OnTriggerExit(Collider ball)
	 {
         ball.transform.parent   = null ;

		 Debug.Log("Exit");
     }
}
