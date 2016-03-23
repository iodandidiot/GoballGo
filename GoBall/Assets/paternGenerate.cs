using UnityEngine;
using System.Collections;

public class paternGenerate : MonoBehaviour {

    public GameObject[] patterns;
    public GameObject ball;
    private GameObject curPattern;
    private GameObject nextPattern;
    float countNextPattern;
	// Use this for initialization
	void Start () 
    {
        curPattern = (GameObject)Instantiate(patterns[0]);
        patternScript PS = curPattern.GetComponent<patternScript>();
        curPattern.transform.position = new Vector2(ball.transform.position.x, ball.transform.position.y - 0.52f);
        PS.ball = ball;
        PS.generate = gameObject.GetComponent<paternGenerate>();
        //countNextPattern = PS.Size - 2;
	}
	
	// Update is called once per frame
    void Update()
    {

    }
    public void Generate()
    {
        nextPattern = (GameObject)Instantiate(patterns[Random.Range(0, patterns.Length)]);
        patternScript nextPS = nextPattern.GetComponent<patternScript>();
        patternScript curPS = curPattern.GetComponent<patternScript>();
        nextPattern.transform.position = new Vector2(curPattern.transform.position.x + curPS.Size/2 + nextPS.Size / 2 - 0.5f, curPattern.transform.position.y);
        nextPS.ball = ball;
        nextPS.generate = gameObject.GetComponent<paternGenerate>();
        curPattern = nextPattern;
    }
}
