using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

    public static gameController instance;

    public GameObject gameOverText;
    public bool gameOver = false;

    public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake ()
    {
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
	void Update ()
    {
		if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
