using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{

    public class GroundScript : MonoBehaviour
    {

        [SerializeField]
        private hotairballoon firstBlockbool;
        public AudioSource explode;

        // Use this for initialization
        void Start()
        {



        }

        // Update is called once per frame
        void Update()
        {
            explode = GetComponent<AudioSource>();

        }
        private void OnCollisionEnter2D(Collision2D collision)

        {



            if (!(collision.gameObject.tag == "baseBlock"))//if its not baseblock
            {
                firstBlockbool.resize();
                Destroy(collision.gameObject);
                explode.Play();


            }
        }
    }
}
