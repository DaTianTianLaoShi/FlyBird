using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstPool : MonoBehaviour
{
    public static ConstPool instance;
    public GameObject ConstPerfab;
    public Transform Max;
    public Transform Min;
    public float Timer = 4;
    public float Times = 0;
    public GameObject[] Consts = new GameObject[5];
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Vector2 ConstStartPosition = new Vector2(2,100);
        for (int i=0; i<5;i++)
        {
            Consts[i] = Instantiate(ConstPerfab,ConstStartPosition,Quaternion.identity); 
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.Gameover==false)
        {
            Times += Time.deltaTime;
            if (Times>=Timer)
            {
                
                AddConst();
                Times = 0;
            }
        }
    }
    void AddConst()
    {
        Consts[n].SetActive(true);
        Vector2 ConstPosition = Vector2.Lerp((Vector2)Max.position,(Vector2)Min.position,Random.Range(0f,1f));
        Consts[n].transform.position = ConstPosition;
        Consts[n].gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(GameController.instance.scollSpeed, 0);
        n++;
        if (n>=5)
        {
            n = 0;
        }
    }
}
