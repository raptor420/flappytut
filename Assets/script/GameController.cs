using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public static GameController instance;
    
    public GameObject gameovertext;
    public bool gameover = false;
    public float ScrollSpeed = -1.5f;
    private int  score = 0;
    public Text scoretext;
	// Use this for initialization
	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BirdScore()
    {
        if(gameover == true)
        {
            return;
        }
        score++;
        scoretext.text = "Score " + score.ToString();

    }

    public void BirdDied()
    {
        gameovertext.SetActive(true);
        gameover = true;
       

    }
}
