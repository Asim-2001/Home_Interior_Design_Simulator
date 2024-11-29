using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Change_Texture : MonoBehaviour
{
    public string Function_tag;
    public Shader shader;
    public Texture texture1;
    public Texture texture2;
    public Texture texture3;
    public Texture texture4;
    public Texture texture5;
    public Texture texture6;
    public Texture texture7;
    public Texture texture8;
    public Texture texture9;
    //public Color color;


    public void Change1()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
     renderer.material.mainTexture = texture1;
       // renderer.material.color = Color.blue;

    }
    public void Change2()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
       renderer.material.mainTexture = texture2;
     //   renderer.material.color = Color.green;
    }
    public void Change3()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
       renderer.material.mainTexture = texture3;
       // renderer.material.color = Color.yellow;

    }
    public void Change4()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
        renderer.material.mainTexture = texture4;
      // renderer.material.color = Color.cyan;
    }
    public void Change5()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
        renderer.material.mainTexture = texture5;
      // renderer.material.color = color;

    }
    public void Change6()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
        renderer.material.mainTexture = texture6;
        // renderer.material.color = Color.red;
    }
    public void Change7()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
        renderer.material.mainTexture = texture7;
        // renderer.material.color = Color.red;
    }
    public void Change8()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
        renderer.material.mainTexture = texture8;
        // renderer.material.color = color;

    }
    public void Change9()
    {
        Renderer renderer = GameObject.FindGameObjectWithTag(Function_tag).GetComponent<Renderer>();
        renderer.material = new Material(shader);
        renderer.material.mainTexture = texture9;
        // renderer.material.color = Color.red;
    }

}
