using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcompleted : MonoBehaviour {

    [SerializeField]
    private int speed;
    private hotairballoon firstBlockbool;
    [SerializeField]
    private Vector2 endpoint;
    [SerializeField]
    private Vector2 spawnpoint;

    // Use this for initialization
    void Start()
    {
        this.gameObject.transform.position = spawnpoint;
        firstBlockbool = FindObjectOfType<hotairballoon>();//

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((speed) * new Vector2(1, 0) * Time.deltaTime);
        if ((gameObject.transform.position.x) <endpoint.x)
        {
            Destroy(this.gameObject);

        }


    }
    void respawn()
    {
        this.gameObject.transform.position = spawnpoint;

    }
   


    }


