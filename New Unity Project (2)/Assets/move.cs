using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public Rigidbody2D rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb = GetComponent<Rigidbody2D>();
       rb.MovePosition(transform.position + new Vector3(0,-1,0)* Time.deltaTime);
    }

}
