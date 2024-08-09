using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    public Slider progressBar;
    public GameObject text;
    public int SceneID;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        StartCoroutine(LoadSceneGame());
    }
    IEnumerator LoadSceneGame()
    {
        AsyncOperation LoadAsync = SceneManager.LoadSceneAsync(SceneID);
        LoadAsync.allowSceneActivation = false;

        while (!LoadAsync.isDone)
        {
            progressBar.value = LoadAsync.progress;

            if (LoadAsync.progress >= 0.9f)
            {
                text.SetActive(true);
                progressBar.value = 1.0f;

                if (Input.anyKeyDown)
                    LoadAsync.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
