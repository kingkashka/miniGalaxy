using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Session : MonoBehaviour
{
    int loadTime = 3;

    // Start is called before the first frame update
    private void Awake()
    {
        int numberGameSessions = FindObjectsOfType<Session>().Length;

        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public void LoadNextScene()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(LoadLevel());
        }
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(loadTime);

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
