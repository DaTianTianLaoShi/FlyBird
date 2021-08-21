using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingGameObject : MonoBehaviour {
    private Rigidbody2D Rb2d;
	// Use this for initialization
	void Start () {
          this.GetComponent<Rigidbody2D>().velocity = new Vector2(GameController.instance.scollSpeed,0);//给背景一个速度向量
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameController.instance.Gameover)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2();//死亡后停止运动，速度为0
        }
	}
}
