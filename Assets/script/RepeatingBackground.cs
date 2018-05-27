using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {
    private BoxCollider2D GroundCollider;
    private float GroundHorizontalLength;
	// Use this for initialization
	void Start () {
        GroundCollider = GetComponent<BoxCollider2D>();
        GroundHorizontalLength = GroundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -GroundHorizontalLength)
        {
            RepositionBackGround();

        }
        Debug.Log("Groundholen"+ transform.position.x.ToString());
	}

    private void RepositionBackGround()
    {

        Vector2 groundoffset = new Vector2(GroundHorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + groundoffset;
    }
}
