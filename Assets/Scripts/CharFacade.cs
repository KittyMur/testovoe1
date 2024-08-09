using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharFacade : MonoBehaviour
{
    public GameObject characterView;
    public Character charStats;
    private CharInterface[] movementModules;

    void Start()
    {
        characterView = gameObject;
        movementModules = GetComponents<CharInterface>();
        StartCoroutine(Actions());
    }
    IEnumerator Actions()
    {
        while (true)
        {
            foreach (var module in movementModules)
            {
                module.Move(characterView, charStats);
            }
            yield return null;
        }
    }
}
