using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefloor : MonoBehaviour {

	Vector3 startpos;
    float i = 0;
	public float speedright =0.05f;
	public int  direction = -1;  // 1向右 -1向左 

    void Start () {
        startpos = transform.position;
    }


    void Update () {
        i += speedright;
        float dis = Mathf.PingPong(i,9);
        transform.position = startpos + Vector3.right * dis * direction ;
	}
}
