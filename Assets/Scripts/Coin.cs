using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(GameController.instance.scollSpeed,0);
        
    }
    private void Update()
    {
        if (GameController.instance.Gameover==true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
