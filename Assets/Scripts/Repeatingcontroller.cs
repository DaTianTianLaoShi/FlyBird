using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeatingcontroller : MonoBehaviour {
    private float groundWrith;
    void Start ()
    {
        groundWrith = GetComponent<BoxCollider2D>().size.x;//通过碰撞器的属性获取背景长度;
	}
	void Update ()
    {
        if (this.transform.position.x+ groundWrith<0)//当背景图片x相对于自身的偏移量大于自身宽度时
        {
            this.transform.position = new Vector2(this.transform.position.x+ groundWrith*2,this.transform.position.y);//就向着运动相反方向移动两个自身宽度
        }
	}
}
