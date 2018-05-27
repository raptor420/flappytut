using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour {

    private bool isdead = false;
    private Rigidbody2D rb2d;
   // private PolygonCollider2D p2d;
    public float upforce=200;
    private Animator Anim;
    public float offx;
    public float offy;
        
        void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
      //  p2d = GetComponent<PolygonCollider2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (!isdead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;

                rb2d.AddForce(new Vector2(0, upforce));
                Anim.SetTrigger("Flap");
             //   Vector2 mov = new Vector2(offx,offy);
            //p2d.transform.Translate(mov);
                
            }

        }

        else if (isdead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
		
	}

    void OnCollisionEnter2D()
    {
        isdead = true;
        Anim.SetTrigger("Die");
        GameController.instance.BirdDied();



    }
}
