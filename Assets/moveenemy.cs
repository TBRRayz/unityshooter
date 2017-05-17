using UnityEngine;
using System.Collections;

public class moveenemy : MonoBehaviour {
	
	public float speed = -3;
	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter(Collision bots)
	{
		if(bots.gameObject.name == "Bot")
		{
			Destroy(gameObject);
            scoreScript.lives -= 1f;
		}
        if (bots.gameObject.name == "Cannon")
        {
            Destroy(gameObject);
            scoreScript.lives -= 1f;
        }
		
		if(bots.gameObject.name == "prefKogel(Clone)")
		{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
		
		
	}
	
	
			
	
}