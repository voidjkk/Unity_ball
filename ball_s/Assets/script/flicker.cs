using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour {
	//要讓物體閃爍記得去material那邊把rendering mode 改成 transparent
    private float AlphaValue = 1.0f;//透明度
    private float passtime = 0.0f;     //時間
	private bool  cube_collider ;

    public float FlickRate = 1.0f; //改此參數可調整閃爍速率(滑順)
    public float colorR ,colorG , colorB ;
	
	
	void Start() //取得物體原來的RGB值
	{
		colorR = this.GetComponent<MeshRenderer>().material.color.r;
		colorG = this.GetComponent<MeshRenderer>().material.color.g;
		colorB = this.GetComponent<MeshRenderer>().material.color.b;
	}
	
	
    void Update()
    {
		
		passtime = Time.time;
		flickeraction();
		getcolor();
		
    }
	
	
	
	void getcolor() //更改透明度 (好像不能省略RGB的值所以在START先取值,讓閃爍時保持顏色一致)
    {

		this.GetComponent<MeshRenderer>().material.color = new Color(colorR,colorG,colorB, AlphaValue);
	}
	void flickeraction()
	{		

         //數值不斷重複從0數到1(超過1會重新從0開始算) 改變color中的A值(透明度)
         AlphaValue = Mathf.PingPong(passtime*FlickRate, 1);            

		
	    if (AlphaValue <=0.4f )
           cube_collider = false;
	    else 
		   cube_collider =true;
		
		this.GetComponent<Collider>().enabled = cube_collider;
		
	}
}
