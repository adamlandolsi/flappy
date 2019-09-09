using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Move : MonoBehaviour
{
    bool isDead;
    public GameObject ReplayButton;
    

    void OnCollisionEnter2D(Collision2D coll)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        ReplayButton.SetActive(true);

        GetComponent<Animator>().SetBool("IsDead", true);
    }
    
    public void replay()
    {
        SceneManager.LoadScene(0);
    }
    Rigidbody2D rb2d;
    
    public float speed = 20f;
    public float flapforce = 50f;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&!isDead)
        {
            rb2d.velocity = Vector2.right * flapforce * Time.deltaTime;
            rb2d.AddForce(Vector2.up * flapforce);
        }
    }
    public void UnFreeze()
    {
        Time.timeScale = 1;
    }
    int Score = 0;
    public Text scoretext;
     void OnTriggerEnter2D(Collider2D coll)
    {  if (coll.gameObject.tag == "score")
        {
            Score++;
            Debug.Log(Score);
            scoretext.text = Score.ToString();
        }
    }

}
