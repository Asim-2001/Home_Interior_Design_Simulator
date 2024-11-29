using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texture_Picker : MonoBehaviour
{
    public string Function_tag;
    public Color C1;
    public Color C2;
    public Color C3;
    public Color C4;
    public Color C5;
    public Color C6;
    public Color C7;
    public Color C8;
    public Color C9;
    public void Change1()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
      
       renderer.material.color =C1;

    }
    public void Change2()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
      
     renderer.material.color = C2;
    }
    public void Change3()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
       
      renderer.material.color = C3;

    }
    public void Change4()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
      
       renderer.material.color = C4;
    }
    public void Change5()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
  
      renderer.material.color = C5;

    }
    public void Change6()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
  
     renderer.material.color = C6;
    }
    public void Change7()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
       
      renderer.material.color = C7;
    }
    public void Change8()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
 
        renderer.material.color = C8;

    }
    public void Change9()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
      
        renderer.material.color =C9; 
    }
}
