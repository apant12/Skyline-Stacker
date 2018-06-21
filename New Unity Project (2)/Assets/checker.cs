using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checker : MonoBehaviour {
    private hotairballoon firstBlockbool;
    Scene scene = SceneManager.GetActiveScene();
    private void Start()
    {

        firstBlockbool = FindObjectOfType<hotairballoon>();
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {


        firstBlockbool = FindObjectOfType<hotairballoon>();
        // firstBlockbool.collisonadder();
        //if (this.transform.localScale.x == collision.transform.localScale.x )//* (3.75f / 4f))
            print("ayushcc");

        if (collision.gameObject.tag == "buildingBlock")

        {
            firstBlockbool.counterblockl1();
            if (SceneManager.GetActiveScene().name == "Start")
            {
                if (collision.transform.localScale.x >= -0.01004417)
                {
                    print("ayushccd");

                    firstBlockbool.checkwin();

                }
            }
            if (SceneManager.GetActiveScene().name == "level 2")
                print("ayushccd");
            {
                if (collision.transform.localScale.x >= -0.01576463)
                {
                    

                    firstBlockbool.checkwin();

                }
            }
            if (SceneManager.GetActiveScene().name == "level3")
                print("ayushccd");
            {
                if (collision.transform.localScale.x >= -0.0137034)
                {


                    firstBlockbool.checkwin();

                }
            }



            if (collision.transform.tag == "ground")

            {
                firstBlockbool.counterblocks1();
              

            }
        }

    }
}
