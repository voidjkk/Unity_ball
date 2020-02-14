using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Playercontroller1 : MonoBehaviour {
  
    public float speed = 1; //for移動速度
    private Vector3 MoveVec; //移動的向量

    private Transform main_camera_transform; //攝影機位置

   //創一個存鋼體的變數
  private Rigidbody rb ;

  private int count ;
  public Text countshow ;  //宣告一個Text的物件
  public Text Wintext ;

  //跳躍
  public float force ;
    

  //die
  public bool isAlive = true ; 
  public AudioClip die_sound;
  public GameObject gameoverpanel;

  void Start()
  {
      main_camera_transform = Camera.main.transform; 


      //讓物件存鋼體的資訊
      rb = GetComponent<Rigidbody>() ; 
  
      count = 0 ;
      UpdateScore() ;
      Wintext.enabled = false;


        
    }
  

  void FixedUpdate ()
  {
        float moveHorizontal = Input.GetAxis ("Horizontal");  //讀鍵盤輸入
        float moveVertical   = Input.GetAxis ("Vertical");
        if (moveHorizontal == 0 && moveVertical == 0) //判斷是否按方向鍵移動 沒有就要停止施力 
            MoveVec = Vector3.zero;

      if (main_camera_transform) //讓主角的前方和攝影機的"前方"一致
         this.transform.eulerAngles = new Vector3(0, main_camera_transform.eulerAngles.y, 0);

        if (Input.GetKey(KeyCode.W))
            MoveVec = this.transform.forward ;
        if (Input.GetKey(KeyCode.S))
            MoveVec = this.transform.forward * - 1;
        if (Input.GetKey(KeyCode.A))
            MoveVec = this.transform.right * -1;
        if (Input.GetKey(KeyCode.D))
            MoveVec = this.transform.right;
     
        rb.AddForce(MoveVec * speed, ForceMode.Force);



    }
    void Update()
    {


        if (this.transform.position.y < -8 && isAlive == true)
            Die();
        if (Input.GetKeyDown(KeyCode.Space))  //跳躍輸入放這邊判定才不會卡卡的 可能因為比FixedUpdate 刷新快( <0.02秒 )
            Jump();
    }






  public void getscore()
    {
        count++;
        UpdateScore();
    }

  void UpdateScore()
  {
	   countshow.text = "collection:" + count + " / 3" ;
		   // Wintext.enabled = true ;   
  }

  void Jump()
    {
     // 從自身打出一條向下射線
      Ray jumpRay = new Ray(this.transform.position, Vector3.down);

        
     if (  Physics.Raycast(jumpRay , 0.3f)  )   //打射線判斷有無打到地板,有接觸則回傳true 可以跳  

        {
            rb.velocity = Vector3.up * force *1.2f ;     //用velocity當作跳躍力感覺比較好不會讓物體往前+跳躍時飛出
            Debug.Log("jump");
        }
   }

  void Die()
    {
        isAlive = false;
        AudioSource.PlayClipAtPoint(die_sound, this.transform.position);
        gameoverpanel.SetActive(true);
        Time.timeScale = 0f;
    }





}
