using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseblock : MonoBehaviour
{

    public static bool blue = true;
    private int counter = 0;
   

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print("collisonwork");
        /*
        if (collision.gameObject.CompareTag("blackblock"))
            if(blue=false)
        {
            {
               


            }
        }

        */

        //  print("Collided");
        counter++;
      //  print("Counter is " + counter);
        if (counter > 1)
        {
            blue = false;
            
            //  print("Collided " + blue);
            counter = 0; 

        }
    


    }
}
