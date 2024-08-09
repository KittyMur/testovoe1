using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCharacter : MonoBehaviour
{
    public Character[] prefabsPlayer;
    public GameObject Loading;
    void Start()
    {
        Loading.GetComponent<Load>().SceneID = 0;
        int index = PlayerPrefs.GetInt("SelectPlayer");
        Instantiate(prefabsPlayer[index].Prefab);
    }

    public void ExittoMenu()
    {
        SceneManager.LoadScene("Loading");
    }
}
