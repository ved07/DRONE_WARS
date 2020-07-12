using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    public float speed = 30;
    public bool isEnemy;
    [SerializeField] GameObject miniExplosion;
    public string ignoredtag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(ignoredtag))
        {

            if (isEnemy)
            {
                if (collision.gameObject != gameObject.transform.parent.gameObject)
                {
                    Instantiate(miniExplosion, transform.position, transform.rotation);
                    Destroy(gameObject);
                }

            }
            else
            {
                Instantiate(miniExplosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
                

        }
        
        
    }
}
