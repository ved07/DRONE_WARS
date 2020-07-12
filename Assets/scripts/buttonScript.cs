using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class buttonScript : MonoBehaviour

{
    [SerializeField] bool useOpen;
    [SerializeField] int sceneToOpen = 2;

    // Start is called before the first frame update
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        if (useOpen)
        {
            button.onClick.AddListener(openScene);
        }
        else
        {
            button.onClick.AddListener(closeScene);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void openScene()
    {
        SceneManager.LoadScene(sceneToOpen);
    }
    void closeScene()
    {
        Application.Quit();
    }

}
