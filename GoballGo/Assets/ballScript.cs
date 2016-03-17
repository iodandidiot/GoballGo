using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {

    bool big,small=false;
    bool normal = true;
	// Use this for initialization
	void Start () 
    {
        Rigidbody2D rigid = gameObject.GetComponent<Rigidbody2D>();
        rigid.AddTorque(-180);
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Rigidbody2D rigid = gameObject.GetComponent<Rigidbody2D>();
        //rigid.AddTorque(-180);
	}

    public void ScaleBig()
    {
        if (normal)
        {
            big = true;
            normal = false;
            gameObject.transform.localScale = new Vector2(1.25f, 1.25f);
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
            gameObject.transform.localScale = new Vector2(0.75f, 0.75f);
        }
        if (big)
        {
            gameObject.transform.localScale = new Vector2(1, 1);
            big = false;
            normal = true;
        }

    }
}
