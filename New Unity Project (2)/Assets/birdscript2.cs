using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript2 : MonoBehaviour
{
    
    [SerializeField]
    private int speed;
    private hotairballoon firstBlockbool;
    [SerializeField]
    private Vector2 endpoint;
    [SerializeField]
    private Vector2 spawnpoint;
    float alphaLevel;
    float alphaFactor;
    public float totallyDarkHeight = 1000f;
    [SerializeField]
    public AudioSource birdsound;
    // Use this for initialization
    void Start()
    {
       // this.gameObject.transform.position = spawnpoint;
        firstBlockbool = FindObjectOfType<hotairballoon>();//
        birdsound = GetComponent<AudioSource>();
        alphaFactor = 1 / totallyDarkHeight;
        birdsound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((speed) * new Vector2(0, 1) * Time.deltaTime);


        if ((gameObject.transform.position.x) > endpoint.x)
        {
            //respawn();

        }


    }
    void respawn()
    {
       // this.gameObject.transform.position = spawnpoint;

    }
    private void OnCollisionEnter2D(Collision2D collision)

    {
        


        if (!(collision.gameObject.tag == "baseBlock"))
        {


            //if its not baseblock

            firstBlockbool.resize();
            firstBlockbool.collisonsubstracter();
            birdsound.Play();
            Destroy(collision.gameObject);


            Destroy(gameObject);
            print("birdexplode");

            firstBlockbool.updatelives();





        }

    }
    void FixedUpdate()
    {
        alphaLevel = alphaFactor * transform.position.y;
        if (alphaLevel > 1)
        {
            alphaLevel = 1;
        }
       // gameObject.SpriteRenderer.color = new Color(1f, 1f, 1f, alphaLevel);
    }

}


