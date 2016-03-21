using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject ball;
    Vector2 ballPosition;

	// Use this for initialization
	void Start () 
    {
        ballPosition = ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        gameObject.transform.position = new Vector3(ball.transform.position.x,transform.position.y,-10f);
        //gameObject.transform.position =(Vector2)ball.transform.position;
	}
}
