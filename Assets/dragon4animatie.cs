using UnityEngine;
using System.Collections;

public class dragon4animatie : MonoBehaviour {

    public float FPS;
    public Texture[] frames;
    private float secWachttijd;
    private int huidigFrame;
    public bool herhaal;


	// Use this for initialization
	void Start () {

        huidigFrame = 0;
        secWachttijd = 1 /FPS;
	    
        StartCoroutine(AnimatieRoutine());
	}
    IEnumerator AnimatieRoutine()
    {
        bool stoppen = false;

        if (huidigFrame >= frames.Length)
        {
            if (!herhaal)
            {
                stoppen = true;
            }
            else
            {
                huidigFrame = 0;
            }
        }


        yield return new WaitForSeconds(secWachttijd);

        renderer.material.mainTexture = frames[huidigFrame];
        huidigFrame++ ;

        if (!stoppen)
        {
            StartCoroutine(AnimatieRoutine());
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
