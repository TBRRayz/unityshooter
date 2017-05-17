using UnityEngine;
using System.Collections;

public class spanscript : MonoBehaviour {
	
	float spwantime = 1f;
	float nextspwantime = 3f;
	float speedturbo = 0f;
	float random;
	int random2;
	
	public Transform enemey1;
	public Transform enemey2;
    public Transform enemey3;
    public Transform enemey4;
	// Use this for initialization
	void Start () {
	
			random = Random.Range(-7.5f, 7.5f);
			random2 = Random.Range(0, 4);
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Time.time >= spwantime)
		{
			print (random2);
			if (random2 == 1)
			{
				
				Instantiate(enemey1, new Vector3(random, transform.position.y - 1, 0), Quaternion.identity);
				
			}else if (random2 == 2)
            {
				Instantiate(enemey2, new Vector3(random, transform.position.y - 1, 0), Quaternion.identity);
            }
            else if (random2 == 3)
            {
                Instantiate(enemey3, new Vector3(random, transform.position.y - 1, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(enemey4, new Vector3(random, transform.position.y - 1, 0), Quaternion.identity);
            }
			
				spwantime = Time.time + nextspwantime;
				speedturbo = speedturbo + 1;
			
				if (speedturbo >= 10)
				{
					nextspwantime = 2f;
				}
				if (speedturbo >= 20)
				{
					nextspwantime = 1f;
				}
				random = Random.Range(-8.2f, 8.2f);
				random2 = Random.Range(0, 4);
			
		}
	
	}
}
