using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class seletlevel_button : MonoBehaviour {

    public void clickLV1()
    {
        SceneManager.LoadScene("level1");
        Debug.Log("進入第一關");
    }

    public void clickLV2()
    {
        SceneManager.LoadScene("level2");
        Debug.Log("進入第二關");
    }

    public void clickSelectStage()
    {
        SceneManager.LoadScene("selectstage");
        Debug.Log("進入關卡選擇");
    }

    public void click_menu()
    {      
        SceneManager.LoadScene("title");
        Debug.Log("進入首頁");
    }


}
