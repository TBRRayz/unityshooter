using UnityEngine;
using System.Collections;

public class kogelScript : MonoBehaviour {
	
	public float speed = 4;
	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter(Collision bots)
	{
		if(bots.gameObject.name == "Boven")
		{
			Destroy(gameObject);
		}
		if(bots.gameObject.name == "dragon1(Clone)")
		{
			scoreScript.score += 1f;
			Destroy(gameObject);
		}
		if(bots.gameObject.name == "dragon2(Clone)")
		{
			scoreScript.score += 2f;
			Destroy(gameObject);
		}
        if (bots.gameObject.name == "dragon3(Clone)")
        {
            scoreScript.score += 3f;
            Destroy(gameObject);
        }
        if (bots.gameObject.name == "dragon4(Clone)")
        {
            scoreScript.score += 4f;
            Destroy(gameObject);
        }
	}
	
	
	
	// Update is called once per frame
	void Update () {
	
		transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
		
		
	}
	
	
			
	
}
