using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds2 : MonoBehaviour
{
    [SerializeField]
    private Vector2 endpoint;
    [SerializeField]
    private Vector2 spawnpoint;
    private hotairballoon firstBlockbool;

    // Use this for initialization
    void Start()
    {
        this.gameObject.transform.position = spawnpoint;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((5) * new Vector2(1, 0) * Time.deltaTime);
        if ((gameObject.transform.position.x) > endpoint.x)
        {
            respawn();

        }


    }
    void respawn()
    {
        this.gameObject.transform.position = spawnpoint;

    }
}
