using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scri: MonoBehaviour
{

    [SerializeField]
    private hotairballoon firstBlockbool;
    public AudioSource explode;

    // Use this for initialization
    void Start()
    {
        firstBlockbool = FindObjectOfType<hotairballoon>();

       

    }

    // Update is called once per frame
    void Update()
    {
        explode = GetComponent<AudioSource>();


    }
    private void OnCollisionEnter2D(Collision2D collision)

    {


        print("Collided");

        print(collision.gameObject.tag + "ayush");

        if (!(collision.gameObject.tag == "baseBlock"))//if its not baseblock
        {
            firstBlockbool.counterblocks1();
            
            //firstBlockbool.resize();
            //firstBlockbool.collisonsubstracter();
            Destroy(collision.gameObject);
            explode.Play();
            firstBlockbool.updatelives();
            print("explode");

        }
        else
        {
           // firstBlockbool.counterblockl1();
           // firstBlockbool.resize();
            //firstBlockbool.collisonsubstracter();
            firstBlockbool.birdfirstb();
            explode.Play();
            firstBlockbool.updatelives();
            Destroy(collision.gameObject);




        }
        /*
          {

              if (collision.gameObject.CompareTag("ground"))
              {
                  print(a + " " + b);
                  a = a * (4f / 3f);
                  b = b * (4f / 3f);
                  Destroy(this.gameObject);


              }
              if (!collision.gameObject.CompareTag("ground"))
              {
                  if (buildingBlockNew.transform.localScale.x != collision.transform.localScale.x * (3f / 4f))
                  {

                      //  print("abc");

                      Destroy(this.gameObject);


                  }
              }
          }
          */

    }
}



