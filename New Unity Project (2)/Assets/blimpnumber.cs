using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blimpnumber : MonoBehaviour {

    // Use this for initialization

    [SerializeField]
    private int speed;
    private hotairballoon firstBlockbool;
    [SerializeField]
    private Vector2 endpoint;
    [SerializeField]
    private Vector2 spawnpoint;
    
    [SerializeField]
    public AudioSource birdsound;
    // Use this for initialization
    void Start()
    {
        // this.gameObject.transform.position = spawnpoint;
        firstBlockbool = FindObjectOfType<hotairballoon>();//
        
        //alphaFactor = 1 / totallyDarkHeight;

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


            Destroy(collision.gameObject);


            Destroy(gameObject);
            ;

            firstBlockbool.updatelivesadd();





        }
    }
        void FixedUpdate()
    {
      
        // gameObject.SpriteRenderer.color = new Color(1f, 1f, 1f, alphaLevel);
    }

}




