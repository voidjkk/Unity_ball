using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller1 : MonoBehaviour {

    //[SerializeField] 代表可以將private的數值顯示在inspector 但還是保持private的特性不讓其他地方取用該值
   [SerializeField] private GameObject player ;
	
	private Vector3 offset ;
    private float x, y , z ;

	// 一開始先算出攝影機和控制角色的位置差值
	void Start () {  
		offset  = transform.position - player.transform.position ;
	}
	
	
	// 保持攝影機距離
	void LateUpdate () {
		
		transform.position = player.transform.position + offset ;
        Rotate();

    }

    private void Rotate()
    {
        if (Input.GetMouseButton(0))
        {
            //紀錄旋轉前一次的位置
            Vector3 pos = transform.position;
            Vector3 rot = transform.eulerAngles;

            //目標為主角 以面向的y軸做旋轉
            transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Mouse X") * 5);  



            y = transform.eulerAngles.y;
            Debug.Log(   string.Format("y = {0:0.00} rot y = {1:0.00} ", y  , rot.y) );

            //控制轉動的範圍,無法旋轉的區域
         /*   if (y > 90 && y < 270)
            {
                transform.position = pos;
                transform.eulerAngles = rot;

            } */

            //  更新相对差值 (這段不加會不繞主角轉)
            offset = transform.position - player.transform.position;
        }

    }


}