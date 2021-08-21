using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public bool Gameover = false;
    public float scollSpeed=10f;
    public static GameController instance;
    public GameObject GameOverText;
    public Text scoreText;
    public Text CoinText;
   // public GameObject Peferb;//预制体
    private int score=0;
    private int Coin = 0;
     void Awake()
    {
        instance = this;
    }
    // Use this for initialization

    void Start () {
       // GameObject com= Instantiate(Peferb,Vector3.zero,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        if (Gameover==true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel(Application.loadedLevelName);
            }
        }
	}
    public void IsGameOver()
    {
        Gameover = true;
        GameOverText.SetActive(true);

    }
    public void BirdScord()
    {
        if (Gameover==true) return;
        score++;
        scoreText.text = "score:" + score;
    }
    public void Count()//金币增加UI
    {
        if (Gameover == true) return;
        Coin++;
        CoinText.text = "Coin" + Coin;

    }
}
