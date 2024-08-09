using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterHill : CharInter
{
    public GameObject dmge;
    public bool hpdown;
    public override void rayDraw()
    {
        base.rayDraw();

        StartCoroutine(InputCorutine());

        if (Physics.Raycast(ray, out hit, rayLength))
        {
            dmge = GameObject.FindGameObjectWithTag("damage");

            if (hit.transform.CompareTag("hill"))
            {
                newText = ("PRESS [E] TO BE HEALTHY");
                hpdown = false;
            }

            if (hit.transform.CompareTag("dmg"))
            {
                newText = ("PRESS [E] TO NOT BE HEALTHY");
                hpdown = true;
            }      
        }
        else newText = " ";
    }
    IEnumerator InputCorutine()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (hpdown == false)
                {
                    dmge.GetComponent<Image>().enabled = false;
                }

                if (hpdown == true)
                {
                    dmge.GetComponent<Image>().enabled = true;
                }
            }

            yield return null;
        }
    }
}
