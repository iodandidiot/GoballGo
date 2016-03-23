using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ballScript : MonoBehaviour {

    bool big,small=false;
    bool normal = true;
    Vector2 velocity = new Vector2(4,-8f);
	// Use this for initialization
	void Start () 
    {
        //Rigidbody2D rigid = gameObject.GetComponent<Rigidbody2D>();
        //rigid.AddTorque(-180);

	}
	
	// Update is called once per frame
	void Update () 
    {
        velocity.x += 0.01f;
        Rigidbody2D rigid = gameObject.GetComponent<Rigidbody2D>();
        rigid.MovePosition(rigid.position + velocity * Time.fixedDeltaTime);
	}

    public void ScaleBig()
    {
        if (normal)
        {
            big = true;
            normal = false;
            gameObject.transform.localScale = new Vector2(1.5f, 1.5f);
            Rigidbody2D rigid = gameObject.GetComponent<Rigidbody2D>();
            rigid.AddTorque(-10);
        }
        if (small)
        {
            gameObject.transform.localScale = new Vector2(1, 1);
            small = false;
            normal = true;
        }        
    }
    public void ScaleSmall()
    {
        if (normal)
        {
            small = true;
            normal = false;
            gameObject.transform.localScale = new Vector2(0.5f, 0.5f);
        }
        if (big)
        {
            gameObject.transform.localScale = new Vector2(1, 1);
            big = false;
            normal = true;
        }
    }
    void OnTriggerEnter2D(Collider2D coll) 
    {
        if (coll.name == "end_trigger")
        {
            SceneManager.LoadScene("Game");
        }
    }
}
