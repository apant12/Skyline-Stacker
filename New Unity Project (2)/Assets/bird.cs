using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird: MonoBehaviour
{
    [SerializeField]
    private GameObject birds;
    [SerializeField]
    private int speed;
    private hotairballoon firstBlockbool;
    [SerializeField]
    private Vector2 endpoint;
    [SerializeField]
    private Vector2 spawnpoint;
   
    public AudioSource birdsound;
    // Use this for initialization
    void Start()
    {
        this.gameObject.transform.position = spawnpoint;
        firstBlockbool = FindObjectOfType<hotairballoon>();//
        birdsound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((speed) * new Vector2(-1, 0) * Time.deltaTime);
        

        if ((gameObject.transform.position.x) <endpoint.x)
        {
            respawn();

        }


    }
    void respawn()
    {
        this.gameObject.transform.position = spawnpoint;

    }
    private void OnCollisionEnter2D(Collision2D collision)

    {
        firstBlockbool = FindObjectOfType<hotairballoon>();



        if (!(collision.gameObject.tag == "baseBlock"))
        {
            

            //if its not baseblock

           // firstBlockbool.resize();
           // firstBlockbool.collisonsubstracter();
            birdsound.Play();
            Destroy(collision.gameObject);
            Instantiate(birds, this.transform.position, this.transform.rotation);

            Destroy(gameObject);
            print("birdexplode");
           
            firstBlockbool.updatelives();

            



        }
        else { 
           // firstBlockbool.resize();
            //firstBlockbool.collisonsubstracter();
            firstBlockbool.birdfirstb();
            Destroy(collision.gameObject);
            Instantiate(birds, this.transform.position, this.transform.rotation);

            Destroy(gameObject);
            firstBlockbool.updatelives();
        }

    }
}


