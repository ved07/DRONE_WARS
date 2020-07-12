using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectileGenerator : MonoBehaviour
{
    public bool isEnemy;
    public GameObject projectile;
    public bool regularFire;
    public int seconds;
    int x;
    [SerializeField] int shots = 60;
    [SerializeField] GameObject shotDisplayer;
    Text shotDisplay;
    // Start is called before the first frame update
    void Start()
    {
        if (!isEnemy)
        {
            shotDisplay = shotDisplayer.GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        x += 1;
        if (isEnemy==true)
        {
            if (x >120/seconds)
            {
                Instantiate(projectile, transform.position, transform.rotation, transform.parent.gameObject.transform);
                x = 0;
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {

                if (shots > 0)
                {
                    Instantiate(projectile, transform.position, transform.rotation);
                    shots -= 1;
                    shotDisplay.text = "Shots Left: " + shots;
                }

                    
            }

        }
    }
    

}
