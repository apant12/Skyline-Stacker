using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour
{
    public Rigidbody2D rb;
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
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((speed) * new Vector2(1, 0) * Time.deltaTime);
       
        if ((gameObject.transform.position.x) > endpoint.x)
        {
            respawn();

        }


    }
    void respawn()
    {
        this.gameObject.transform.position = spawnpoint;
        //this.gameObject.transform.position.y += Random.Range(-10.0, 10.0);

    }
     void OnTriggerStay2D(Collider other)

    {
        print("drag");


        //! if ((collision.gameObject.tag == "baseBlock"))//if its not baseblock
        //if(collision.gameObject.name 
        if (other.gameObject.tag == "baseBlock")
        {
            //firstBlockbool.clouddrag();
          //  firstBlockbool.resize();
            //Destroy(collision.gameObject);
            //firstBlockbool.updatelives();



        }
        if ((other.gameObject.tag == "buildingBlock"))
        {
            print("drag");
            other.gameObject.GetComponent<Rigidbody2D>().drag = 130;
            
        }

    }

         void OnTriggerExit2D(Collider other)
        {
        print("exit");

        other.gameObject.GetComponent<Rigidbody2D>().drag = 0;
        print("exit");


        }





    

    
}


