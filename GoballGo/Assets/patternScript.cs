using UnityEngine;
using System.Collections;

public class patternScript : MonoBehaviour {

    public int Size;
    public GameObject ball;
    public paternGenerate generate;
    public bool isGenerate=false;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () 
    {
        if (ball.transform.position.x > gameObject.transform.position.x-2f && !isGenerate)
        {
            generate.Generate();
            isGenerate = true;
        }
        if (ball.transform.position.x - gameObject.transform.position.x > Size/2)
        {
            Destroy(gameObject);
        }
	}
}
