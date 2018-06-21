using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delblock : MonoBehaviour
{

   

    [SerializeField]
   public int counter = 0; 
    [SerializeField]
    private hotairballoon abc;

    bool aa = false;

    private static bool new1;
  


    private void Update()
    {
       

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print("collisonwork");

        
            if (!aa)
        {

            if (!collision.gameObject.CompareTag("blackblock"))
            {


                if (this.transform.localScale.x != collision.transform.localScale.x * (3f / 4f))
                {

                    //  print("abc");

                    Destroy(this.gameObject);


                }
            }
        }
        aa = true;


    }

       
        
    }
  
  

    
