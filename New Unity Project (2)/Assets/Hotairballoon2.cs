using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hotairballoon2 : MonoBehaviour
{
    private int points;

    //[SerializeField] 
    //public AudioSource hbsound;
    public AudioSource dsound;
    [SerializeField]
    private Text youwin;
    [SerializeField]
    private Text scored;
    [SerializeField]
    private Text timers;
    [SerializeField]
    private Transform buildingBlock;
    [SerializeField]
    private Vector2 endpoint;
    [SerializeField]
    private Vector2 spawnpoint;
    // Use this for initialization
    [SerializeField]
    private blockcs blocks;//connected to function
    private int speed = 2;
    private float speed2 = 0;
    private bool firstBlock = true;
    private Transform buildingBlockNew;
    private float a;
    private float b;
    private int counterblock;
    private int towercounter;
    private float c;
    private float d;
    private bool secondfirstblock = true;
    private int score;
    private int lives = 3;
    private float time = 120;
    bool aa = false;
    private float timetrigger = 15;
    private levelcompleted level;
    private int times = 0;


    void Start()
    {
        this.gameObject.transform.position = spawnpoint;
        a = buildingBlock.transform.localScale.x;//putting the value of scale into x
        b = buildingBlock.transform.localScale.y;//puting the value of block's scale into y 
        print(a + " " + b);
        c = a;
        d = b;
        lives++;
        updatelives();





    }

    // Update is called once per frame
    void Update()

    {
        dsound = GetComponent<AudioSource>();
        transform.Translate((speed + speed2) * new Vector2(1, 0) * Time.deltaTime);
        //hbsound.Play();
        if (Input.GetKeyDown("d"))
        {
            dsound.Play();


            buildingBlockNew = generate((Vector2)this.transform.position);

            if (firstBlock)
            {
                buildingBlockNew.name = "baseBlock";
                buildingBlockNew.tag = "baseBlock";
                firstBlock = false;
                print("ayush");
            }

            else if (!firstBlock)
            {
                buildingBlockNew.name = counterblock.ToString();
                buildingBlockNew.tag = "buildingBlock";
                counterblock++;
            }
            speed2 = 2;

        }
        if ((gameObject.transform.position.x) > endpoint.x)
        {
            respawn();

        }
        slowdown();
        checkwin();
        timers.text = time.ToString();
        timer();
        if (lives == 0)
        {

        }
        times -= times;
    }

    public Transform generate(Vector2 balloonPosition)// is to generate to next block but smaller
    {

        Transform myNewBlock = Instantiate(buildingBlock, transform.position, transform.rotation);

        print(firstBlock);

        if (!firstBlock)
        {

            a = a * (3.5f / 4f);
            b = b * (3.5f / 4f);

            print(a + " " + b);

        }
        if (towercounter > 0)
        {
            myNewBlock.localScale = new Vector2(c, d);
            firstBlock = true;
            Start();




        }

        else
        {
            myNewBlock.localScale = new Vector2(a, b);
        }
        return myNewBlock;




        // print("Block counter is " + counter);

        /* if (new1)
         {
             a = a * (3f / 4f);
             b = b * (3f / 4f);
         }

         generate.transform.localScale = new Vector3(a, b);//new block


         print("This new1 is " + new1);

         print(a + " " + b);
         */

    }
    public void slowdown()

    {
        if (speed2 < 0)
        {
            speed2 = 0;
        }

        speed2 -= Time.deltaTime;

    }
    void respawn()
    {
        this.gameObject.transform.position = spawnpoint;

    }



    public int getcounter()
    {
        return counterblock;

    }
    public void resize()
    {
        a = a * (4f / 3.5f);
        b = b * (4f / 3.5f);
    }
    public void checkwin()




    {
        if (a <= 0.512909 && b <= 0.7693634)
        {
            towercounter++;

            print("checkwin");
            youwin.text = "You WIN";
            for (int i = 0; i < 1000000000; i++)
            {
                int j = 0;
                i += i;

            }
            Scene scene = SceneManager.GetActiveScene();
            // yield.WaitForSeconds(1);
            Application.LoadLevel("level 2");



        }
        if (lives == 0)
        {
            youwin.text = "You Lose";
            for (int i = 0; i < 1000000000; i++)
            {
                int j = 0;
                i += i;

            }

            if (times == 0)
            {
                Scene scene = SceneManager.GetActiveScene();

                Application.LoadLevel("Start");


            }
        }

    }

    public void nextower()
    {

    }
    public void scores()
    {
        score++;
        print(score);

    }
    public void updatescore()
    {

    }
    public void livess()
    {

    }
    public void updatelives()
    {
        lives = lives - 1;
        scored.text = "lives:" + lives.ToString();
        print("updatelives");
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        // if(buildingBlockNew.name==)




    }
    public void timer()
    {

        time -= Time.deltaTime;//timer 

    }
}
/*
public blockcs getBlock(){

    return cblock; 
}
*/




