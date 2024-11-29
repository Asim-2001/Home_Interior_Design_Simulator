using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_Selection : MonoBehaviour
{
    public GameObject Pannel;
    public string tag_name;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag== tag_name)
        {
            Pannel.SetActive(true);

        }
        if (collision.collider.tag == "Ground")
        {
            Pannel.SetActive(false);
        }
    }
}
