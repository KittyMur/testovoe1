using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class CharMove : MonoBehaviour, CharInterface
{
    public void Move(GameObject c1, Character c2)
    {
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");
        c1.transform.Translate(Vector3.forward * moveInput * c2.speed * Time.deltaTime);
        Vector3 rot = new Vector3(-rotateInput * 180 * Time.deltaTime, 0f, 0f);
        c1.transform.Rotate(rot);
    }
}
