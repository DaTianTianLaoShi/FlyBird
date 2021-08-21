using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
    private bool isDie=false;
    public float Speed = 200f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isDie == true) return ;
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Speed));
            this.GetComponent<Animator>().SetTrigger("bFly");
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coiin")
        {
            Debug.Log("吃到金币");
            collision.gameObject.SetActive(false);
            GameController.instance.Count();
        }
        else
        {
            this.GetComponent<Animator>().SetTrigger("Isdie");
            isDie = true;
            GameController.instance.IsGameOver();
        }
        
    }

}
