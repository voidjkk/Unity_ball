using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI ;

public class Button_Click : MonoBehaviour {

    public string nowName ;
    public Scene nowscene;

    public GameObject Pausemenu;
    public bool IsPause = false;

     void Start()
  { 
  //取得當前場景名稱 
    Scene nowscene = SceneManager.GetActiveScene();
    Debug.Log("Active scene is '" + nowscene.name + "'.");
        nowName = nowscene.name;
  }

    public void PauseMenu()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        IsPause = true;
    }

    public void Resume()
    {
        if(IsPause == true)
        {
            Pausemenu.SetActive(false);
            Time.timeScale = 1f;
            IsPause = false;
        }
    }

 


    public void clickLV1()
	{
        Time.timeScale = 1f;
        SceneManager.LoadScene("level1") ;
	  Debug.Log("進入第一關");
	}
	public void clickSelectStage()
	{
	  SceneManager.LoadScene("selectstage") ;
	  Debug.Log("進入關卡選擇");
	}
	
	public void clickExit()
	{
	  Application.Quit();

	}
	public void click_menu()
	{
        Time.timeScale = 1f;
        IsPause = false;
        SceneManager.LoadScene("title") ;
	  Debug.Log("進入首頁");
	}
	
	public void click_Restart()
	{
        Time.timeScale = 1f;
        IsPause = false;
        SceneManager.LoadScene(nowName) ;
	  Debug.Log("重置關卡");
	}
}
