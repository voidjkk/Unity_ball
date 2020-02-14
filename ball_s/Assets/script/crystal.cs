using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystal : MonoBehaviour {

    private Playercontroller1 player;   

    public AudioClip pickupsound;
   

    private void OnTriggerEnter(Collider other)
    {
          player = other.GetComponent<Playercontroller1>();  //取得掛載在角色那邊的程式碼 並呼叫加分的函式
        

        if (player)
        {
            player.getscore();
            AudioSource.PlayClipAtPoint(pickupsound, transform.position);
            Destroy(gameObject); //pick up消失

        }
    }
}
