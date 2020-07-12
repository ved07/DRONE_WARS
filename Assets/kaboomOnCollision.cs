using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kaboomOnCollision : MonoBehaviour
{
    public GameObject enemyProj;
    [SerializeField] GameObject Explosion;
    [SerializeField] int health = 100;
    [SerializeField] GameObject wall1;
    [SerializeField] GameObject wall2;
    [SerializeField] GameObject baseObj;
    [SerializeField] bool isPlayer = false;
    [SerializeField] GameObject healthDisplayer;
    Text healthDisplay;

    // Start is called before the first frame update
    void Start()
    {
        if (isPlayer)
        {
            healthDisplay = healthDisplayer.GetComponent<Text>();
            healthDisplay.text = "Health: " + health;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == enemyProj.name)
        {
            health = health- 1;
            if (isPlayer)
            {
                healthDisplay.text = "Health: " + health;
            }
            if (health == 0)
            {
                deathOfPlayer();
            }
        }
        else if (collision.gameObject == wall1  )
        {
            health = 0 ;
            if (health == 0)
            {
                deathOfPlayer();
            }
        }
        else if (collision.gameObject == wall2)
        {
            health = 0;
            if (health == 0)
            {
                deathOfPlayer();
            }
        }
        else if (collision.gameObject == baseObj)
        {
            health = 0;
            if (health == 0)
            {
                deathOfPlayer();
            }
        }
    }
    void deathOfPlayer()
    {
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        if (isPlayer)
        {
            SceneManager.LoadScene(1);
        }
    
    }
}
