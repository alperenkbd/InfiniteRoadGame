using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuniScript : MonoBehaviour {

    public float speed = 0.0485f;

    public AudioSource bounce;

    public GameObject crashsound;

    public Text pointcal;

    int totalpoint;

    public GameObject MainPanel;

    public GameObject scoretext;

    public GameObject ReadyPanel;

    public GameObject speedcontrol;

    public GameObject GameOverPanel;

    int bestscore;

    public Text scorecurrent;

    public Text scorebest;

    void Start()
    {

        speed = 0;

        totalpoint = 0;

        pointcal.text = totalpoint.ToString();

        bounce = GetComponent<AudioSource>();

        bestscore = 0;
        
    }

    private void FixedUpdate()
    {
        move();

        


    }


    void Update()
    {


        if (speed != 0)
        {
            speedcontrol.SetActive(true);

        }
        else
        {
            speedcontrol.SetActive(false);

        }

        PanelControl();

        scorecurrent.text = "SCORE: "+totalpoint.ToString();

        if (totalpoint > bestscore)
        {


            bestscore = totalpoint;

        }

        scorebest.text = "BEST: " + bestscore.ToString();

    }



    void move()
    {

        transform.Translate(0, speed, 0);

        if (Input.GetMouseButton(0))
        {

            transform.Translate(-0.07f, 0, 0);

        }
        if (Input.GetMouseButton(1))
        {

            transform.Translate(+0.07f, 0, 0);

        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "count")
        {



            collision.gameObject.transform.parent.root.gameObject.GetComponent<MovetoNext>().isittouch = true;

            bounce.Play();

            totalpoint++;

            pointcal.text = totalpoint.ToString();

        }
        if (collision.gameObject.tag == "colon")
        {

            crashsound.GetComponent<AudioSource>().Play();

            Time.timeScale = 0;

            GameOverPanel.SetActive(true);


        }
        

    }

    void PanelControl()
    {

        if (MainPanel.active)
        {

            gameObject.SetActive(false);
            scoretext.SetActive(false);

        }
        else
        {

            gameObject.SetActive(true);
            scoretext.SetActive(true);
        }


        if (ReadyPanel.active)
        {

            speed = 0;

            if (Input.GetMouseButton(1) || Input.GetMouseButton(0))
            {

                speed = 0.0485f;

                ReadyPanel.SetActive(false);

            }


        }

        if (GameOverPanel.active)
        {

            scoretext.SetActive(false);

        }


    }
}
