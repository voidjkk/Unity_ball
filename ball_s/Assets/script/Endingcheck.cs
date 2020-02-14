using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endingcheck : MonoBehaviour {

    public GameObject GameEnding;


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            GameEnding.SetActive(true);
        Time.timeScale = 0;
    }


}
