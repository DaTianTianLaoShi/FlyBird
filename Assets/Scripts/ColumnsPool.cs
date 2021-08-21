using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsPool : MonoBehaviour {

    public GameObject ColnumPrefed;//预制物体
    public Transform Max;//随机生成最高点坐标
    public Transform Main;//随机生成的最低点坐标
    public float Times = 4f;//柱子生成时间间隔
   // public float destorytime = 10f;
    public float timer;//计时器
    // Use this for initialization
   private GameObject[] obstacle = new GameObject[5];//创建一个对象池,用来储存五个柱子
    private int q = 0;//记录对象个数
    void Start()
    {
        for (int i=0;i<obstacle.Length; i++)//在对象池；里面添加5个对象
        {
            Vector2 a = new Vector2(0,100);//放到屏幕外面
            obstacle[i] = Instantiate(ColnumPrefed,a,Quaternion.identity);
        }
    }

// Update is called once per frame
void Update()
    {
        if (GameController.instance.Gameover == false)//判断游戏是否结束
        {
            timer += Time.deltaTime;//时间流动
            if (timer > Times)
            {
                Swam();
                timer = 0;
            }
        }
    }
    public void Swam()
    {
        Vector3 a = Vector3.Lerp(Main.position, Max.position, Random.Range(0f, 1f));//在设定范围生成一个坐标
        obstacle[q].transform.position = a;//把对象从0到4移动到具体位置
        q++;
        if (q>=obstacle.Length)
        {
            q = 0;
        }
    }
}
