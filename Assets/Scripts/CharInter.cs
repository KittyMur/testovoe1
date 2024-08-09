using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  abstract class CharInter : MonoBehaviour, CharInterface
{
    public float rayLength = 3f;
    public Ray ray;
    public RaycastHit hit;

    public GameObject hint;
    public string newText;
    // Start is called before the first frame update
    public void Move(GameObject c1, Character c2)
    {
        rayDraw();

        if (Physics.Raycast(ray, out hit, rayLength))
        {
            hint = GameObject.FindGameObjectWithTag("hint");
            hint.GetComponent<Text>().text = newText;
            //else hint.GetComponent<Text>().text = null;
        }
    }

    public virtual void rayDraw()
    {
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.red);
    }

}
