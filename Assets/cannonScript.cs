using UnityEngine;
using System.Collections;

public class cannonScript : MonoBehaviour {
	
	public Transform schietObj;
	public float speed = 6;
	float volgendeSchot = 0.5f;
	float vuurRate = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -8.2f)
		{
			transform.localPosition -= new Vector3(speed * Time.deltaTime,0,0);
		}
		else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8.2f)
		{
			transform.localPosition += new Vector3(speed * Time.deltaTime,0,0);
		}
		
		if (Input.GetAxis("Schot")== 1)
		{
			if (Time.time >= volgendeSchot)
			{
		   		Instantiate(schietObj, new Vector3(transform.position.x, transform.position.y + 1, 0), Quaternion.identity);
				volgendeSchot = Time.time + vuurRate;
			}
		}
		
	
	}
}
