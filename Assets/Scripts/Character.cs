using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/character")]
public class Character : ScriptableObject
{
    public string Name;
    public int speed;
    public GameObject Prefab;
}
