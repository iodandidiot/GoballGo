using UnityEngine;
using System.Collections;

public class paternGenerate : MonoBehaviour {

    public GameObject[] patterns;
    public GameObject ball;
    private GameObject curPattern;
    private GameObject nextPattern;
	// Use this for initialization
	void Start () 
    {
        curPattern = (GameObject)Instantiate(patterns[Random.Range(0, patterns.Length)]);
        patternScript PS = curPattern.GetComponent<patternScript>();
        curPattern.transform.position = new Vector2(ball.transform.position.x + PS.Size/2, ball.transform.position.y - 0.52f);
        PS.ball = ball;
        PS.generate = gameObject.GetComponent<paternGenerate>();           
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    public void Generate()
    {
        nextPattern = (GameObject)Instantiate(patterns[Random.Range(0, patterns.Length)]);
        patternScript PS = nextPattern.GetComponent<patternScript>();
        nextPattern.transform.position = new Vector2(ball.transform.position.x + PS.Size, curPattern.transform.position.y);
        PS.ball = ball;
        PS.generate = gameObject.GetComponent<paternGenerate>();
    }
}
