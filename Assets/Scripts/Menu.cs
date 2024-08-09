using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Character[] characters;
    int index;

    public Text Name;
    public Text Speed;
    public GameObject Prefab;
    public GameObject Loading;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        activeCharacter();
        StartCoroutine(InputCorutine());
    }

    // Update is called once per frame
    IEnumerator InputCorutine()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                StartScene();
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                Left();

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                Right();

            yield return null;
        }
    }

    public void Left()
    {
        if (index != 0)
        {
            Destroy(Prefab);
            index--;
            activeCharacter();
        }
    }

    public void Right()
    {
        if (index != characters.Length - 1)
        {
            Destroy(Prefab);
            index++;
            activeCharacter();
        }
    }
    public void activeCharacter()
    {
        Prefab = Instantiate(characters[index].Prefab);
        Name.text = "Name:" + characters[index].Name;
        Speed.text = "Speed:" + characters[index].speed;
    }
    public void StartScene()
    {
        Loading.GetComponent<Load>().SceneID = 2;
        PlayerPrefs.SetInt("SelectPlayer", index);
        SceneManager.LoadScene("Loading");
        StopCoroutine(InputCorutine());
    }
}
