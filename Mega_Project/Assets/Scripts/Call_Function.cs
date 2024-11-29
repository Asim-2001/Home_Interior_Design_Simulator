using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Call_Function : MonoBehaviour
{
    public GameObject Function_Pannel;
    public GameObject Add_Pannel;
    public GameObject Remove_Pannel;
    public GameObject Change_Pannel;
    public GameObject Texture_Pannel;


public void Add()
    {
     
        Add_Pannel.SetActive(true);
       Function_Pannel.SetActive(false);
    }
    public void Remove()
    {
   Function_Pannel.SetActive(false);
        Remove_Pannel.SetActive(true);

    }
    public void Change()
    {
   Function_Pannel.SetActive(false);
        Change_Pannel.SetActive(true);

    }
    public void Texture()
    {
 Function_Pannel.SetActive(false);
        Texture_Pannel.SetActive(true);

    }
    public void exit()
    {
        Function_Pannel.SetActive(false);
    }

}
