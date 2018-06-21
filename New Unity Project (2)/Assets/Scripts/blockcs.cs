using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockcs : MonoBehaviour
{

    [SerializeField]
    private GameObject blocks;
    private float x;
    private float y;
    private int currblock;
    private int finalblock;
    private float decreaseAmount;
    private float a;
    private float b;
    private static bool new1;

    private Baseblock baser;
    int counter = 0;

    // Use this for initialization
    void Start()
    {
               a = x;
        b = y;

    }

    private void Update()
    {
        new1 = Baseblock.blue;

    }





    public GameObject generate(Vector2 balloonPosition)// is to generate to next block but smaller
    {


        GameObject generate = Instantiate(blocks, balloonPosition, transform.rotation);
        print("Block counter is " + counter);


        if (counter >= 1)
        {
            new1 = true;
        }

        if (new1)
        {

            a = a * (3f / 4f);
            b = b * (3f / 4f);
        }
        else
        {
            counter = counter + 1;
        }



        generate.transform.localScale = new Vector3(a, b);//new block


        print("This new1 is " + new1);

        print(a + " " + b);
        return generate;
    }
    

    
    

}