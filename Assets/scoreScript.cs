using UnityEngine;
using System.Collections;

public class scoreScript : MonoBehaviour {
	
	public static float score = 0f;
    public static float lives = 3f;
	
	
	void OnGUI()
    {
        
        GUI.Label(new Rect(30, 10, 300, 100), "SCORE: " + score);
        GUI.Label(new Rect(30, 30, 300, 100), "LIVES: " + lives);
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
