using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hotairballoon : MonoBehaviour
{
    private int points;

    public Rigidbody rb;
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
    [SerializeField]
    private int speed = 1;
    private float speed2 = 0;
    private bool firstBlock = true;
    private Transform buildingBlockNew;
    private float a;
    private float b;
    private int counterblock;
    private int towercounter;
    private float c;
    private float d;
    private int score;
    private int lives = 3;
    private float time = 120;
    bool aa = false;
    private float timetrigger = 15;
    private levelcompleted level;
    private int times = 0;
    [SerializeField]
    private GameObject pausePanel;
    // var drag: float = 0.01; // drag factor
    //private var rb: Rigidbody;
    [SerializeField]
    private GameObject levelcom;
    private int collisoncounter;
    private float wintimer;
    private bool cou = true;
    [SerializeField]
    private GameObject panelw;
    [SerializeField]
    private GameObject panell;
    private bool levelcomp = true;
    Scene scene = SceneManager.GetActiveScene();
    private int counterblocks;
    private bool empire = false;

    private bool worl = false;


    void Start()
    {
        this.gameObject.transform.position = spawnpoint;
        a = buildingBlock.transform.localScale.x;//putting the value of scale into x
        b = buildingBlock.transform.localScale.y;//puting the value of block's scale into y 
        print(a + " " + b);
        c = a;
        d = b;


        rb = GetComponent<Rigidbody>();
        pausePanel.SetActive(false);
        panelw.SetActive(false);
        panell.SetActive(false);
        Instantiate(levelcom, transform.position, transform.rotation);
        Time.timeScale = 1;




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
        if (time >= 0)
        {

            timers.text = time.ToString("f0");
        }

        timer();


        //   print(wintimer);


        times -= times;
        //blockup = GameObject.Find("counterblock.ToString()");
        rb = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausePanel.activeInHierarchy)
            {
                PauseGame();
            }
            if (pausePanel.activeInHierarchy)
            {
                ContinueGame();
            }
        }
        print(collisoncounter + "collisoncounter");
        if (!worl) {
            checkloss();
        }
        if (lives >= 0)
        {
            scored.text = "lives:" + lives.ToString();
        }

        newtimer();
        print("counterb" + counterblocks);

    }

    public Transform generate(Vector2 balloonPosition)// is to nerate to next block but smaller
    {

        Transform myNewBlock = Instantiate(buildingBlock, transform.position, transform.rotation);

        print(firstBlock);

        if (SceneManager.GetActiveScene().name == "level3")
        {
            print("start");
            if (!firstBlock)
            {
                if (counterblocks == 0)
                {




                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (3.25f / 4f);
                    b = b * (3.25f / 4f);


                    print(a + " " + b);

                    // }

                }
                if (counterblocks == 1)
                {



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (3.25f / 4f);
                    b = b * (3.25f / 4f);


                    print(a + " " + b);

                    // }

                }


                if (counterblocks == 9 )
                {
                    //f (!empire)

                    //  if (!firstBlock)
                    //  {

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (2f / 3f);
                    b = b * (0.5f);

                    print(a + " " + b);

                    //}

                }

                if (counterblocks >= 11 && counterblocks <= 13)
                {
                    a = a * (3.0f / 4f);
                    b = b * (3.0f / 4f);
                }

                if (counterblocks ==15)
                {
                    a = a * (2.4f / 4f);
                    b = b * 2.1f;

                }
                if (counterblocks == 17)
                {
                    a = a * (2.0f / 4f);
                    b = b * 1.5f;

                }
                if (counterblocks >= 19)
                {
                    a = a * (3f / 4f);
                    b = b * 1.3f;

                }
            }
        }
        if (SceneManager.GetActiveScene().name == "level 2")//work25
        {
            print("start2");
            if (!firstBlock)
            {
                if (counterblocks == 0)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * 1f;
                    b = b * 1f;
                    print("empire4");

                    print(a + " " + b);

                }

                if (counterblocks >= 13 && counterblocks <= 18)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (3.5f / 4f);
                    b = b * 1f;
                    print("empire5");

                    print(a + " " + b);

                }
                if (counterblocks >= 19 && counterblocks <= 24)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (2.5f / 4f);
                    b = b * (3f / 4f);
                    print("empire5");

                    print(a + " " + b);

                }

                if (counterblocks >= 24 && counterblocks <= 25)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1f / 1.25f);
                    b = b * (1f / 1.25f);
                    print("empire5");

                    print(a + " " + b);

                }


            }
        }
        if (SceneManager.GetActiveScene().name == "Start")//work25
        {
            print("start3");
            if (!firstBlock)
            {
                if (counterblocks <= 8)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (3.5f / 4f);
                    b = b * (3.5f / 4f);
                    print("empire4");

                    print(a + " " + b);

                }
                /*
                if (counterblocks ==13)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (3.5f / 4f);
                    b = b * (3.5f/4f);
                    print("empire5");

                    print(a + " " + b);

                }
                */
                if (counterblocks >= 9 && counterblock <= 10)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (0.65f);
                    b = b * (0.7f);
                    print("empire5");

                    print(a + " " + b);

                }

                if (counterblocks >10 && counterblocks<12)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (0.60f);
                    b = b * (2.0f);
                    print("empire5");

                    print(a + " " + b);

                }


            }
        }




        // if (towercounter > 0)
        //{
        //  myNewBlock.localScale = new Vector2(c, d);
        //firstBlock = true;
        //Start();




        // }
        //*\



        myNewBlock.localScale = new Vector2(a, b);

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
        if (SceneManager.GetActiveScene().name == "Start")//work25
        {
            print("start3");
            if (!firstBlock)
            {
                if (counterblocks <= 8)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1f/(3.5f / 4f));
                    b = b * (1f/(3.5f / 4f));
                    print("empire4");

                    print(a + " " + b);

                }
                /*
                if (counterblocks ==13)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (3.5f / 4f);
                    b = b * (3.5f/4f);
                    print("empire5");

                    print(a + " " + b);

                }
                */
                if (counterblocks >= 9 && counterblock <= 10)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1/0.65f);
                    b = b * (1/0.7f);
                    print("empire5");

                    print(a + " " + b);

                }

                if (counterblocks > 10 && counterblocks < 12)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (0.60f);
                    b = b * (2f);
                    print("empire5");

                    print(a + " " + b);

                }


            }
        }
        if (SceneManager.GetActiveScene().name == "level 2")//work25
        {
            print("start2");
            if (!firstBlock)
            {
                if (counterblocks == 0)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * 1f;
                    b = b * 1f;
                    print("empire4");

                    print(a + " " + b);

                }

                if (counterblocks >= 13 && counterblocks <= 18)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1f / (3.5f / 4f));
                    b = b * 1f;
                    print("empire5");

                    print(a + " " + b);

                }
                if (counterblocks >= 19 && counterblocks <= 24)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1 / (2.5f / 4f));
                    b = b * (1 / (3f / 4f));
                    print("empire5");

                    print(a + " " + b);

                }

                if (counterblocks >= 22 && counterblocks <= 25)
                {
                    print("empire1");



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1f / (1f / 1.25f));
                    b = b * (1f / (1f / 1.25f));
                    print("empire5");

                    print(a + " " + b);

                }


            }
        }
        if (SceneManager.GetActiveScene().name == "level3")
        {
            print("start");
            if (!firstBlock)
            {
                if (counterblocks == 0)
                {




                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1f / (3.0f / 4f));
                    b = b * (1f / (3.0f / 4f));


                    print(a + " " + b);

                    // }

                }
                if (counterblocks == 1)
                {



                    //f (empire)
                    //
                    // empire = true;

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1f / (3.0f / 4f));
                    b = b * (1f / (3.0f / 4f));


                    print(a + " " + b);

                    // }

                }


                if (counterblocks > 1 && counterblocks <= 7)
                {
                    //f (!empire)

                    //  if (!firstBlock)
                    //  {

                    // a = a * (3.75f / 4f);
                    //b = b * (3.75f / 4f);
                    a = a * (1f / (2f / 3f));
                    b = b * (2f);

                    print(a + " " + b);

                    //}

                }
                if (counterblocks >= 8 && counterblocks <= 9)
                {
                    a = a * (1f / (3.0f / 4f));
                    b = b * (1f / (3.0f / 4f));
                }
                if (counterblocks >= 10 && counterblocks <= 11)
                {
                    a = a * (1f / (3.0f / 4f));
                    b = b * (1f / (3.0f / 4f));
                }

                if (counterblocks > 11)
                {
                    a = a * (1f / (2.5f / 4f));
                    b = b * (1 / 2.5f);

                }
            }
        }





    }
    public void checkwin()




    {
       // if (SceneManager.GetActiveScene().name == "Start")//work25
        {
            worl = true;
            levelchangewin();

            //if (a <= 0.512909 && b <= 0.7693634)
            // {
            //  towercounter++;


            print("checkwin");

            //yield return new WaitForSeconds(10);
            levelchangewin();


           

        }

    }
        public void checkloss()
        {
            if (lives <= 0 || time <= 0)
            {

                bool tou = false;
                if (cou == false)
                {
                    timey();
                    cou = true;
                }
                st();
                timey();
                levelchangelose();

                // if (wintimer <= 0)
                //{


                //  if (SceneManager.GetActiveScene().name == "Start")
                //{
                //  Application.LoadLevel("Start");

                //  }
                //if (SceneManager.GetActiveScene().name == "level 2")
                //{
                //   Application.LoadLevel("level 2");

                //}
                //}




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

        print("updatelives");
    }
    public void updatelivesadd()
    {

        lives = lives + 1;
        scored.text = "lives:" + lives.ToString();
    }


    public void newtimer()
    {
        wintimer -= Time.deltaTime;
    }



    public void timer()
    {

        time -= Time.deltaTime;//timer 
                               // time = ("%.2F", time);
    }
    public void clouddrag()
    {
        //GetComponent<ConstantForces>().force = new Vector2(0, 10f);
        rb.drag = 20;

    }




    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        print("ayush");
        //Disable scripts that still work while timescale is set to 0
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);

        //enable the scripts again
    }
    public void levelchangewin()
    {
        Time.timeScale = 0;
        panelw.SetActive(true);

        if (levelcomp == true)
        {

            levelcomp = false;
        }
        print("ayush");
        //Disable scripts that still work while timescale is set to 0
    }
    public void levelchangelose()
    {
        Time.timeScale = 0;
        panell.SetActive(true);
        if (levelcomp == true)
        {

            levelcomp = false;
        }

        //enable the scripts again
    }
    public void LoadLevel(string name)
    {
        print("Level " + name);
        Application.LoadLevel(name);
    }

    public void quitRequest()
    {
        Application.Quit();
    }


    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void birdfirstb()
    {
        firstBlock = true;
    }
    public void collisonadder()
    {
        collisoncounter++;
    }
    public void collisonsubstracter()

    {
        if (collisoncounter >= 1)
        {
            collisoncounter--;
        }
    }
    public void timey()
    {
        wintimer = 4;
    }
    public void st()
    {
        cou = false;
    }
    IEnumerator Smite()
    {
        yield return new WaitForSeconds(2);


    }
    public void counterblockl1()
    {
        counterblocks = counterblocks + 1;

    }
    public void counterblocks1()
    {
        if (counterblocks > 1)
        {
            counterblocks = counterblocks - 2;
        }
    }
}



        /*
        public blockcs getBlock(){

            return cblock; 
        }
        */
       
   


