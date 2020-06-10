using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPatternBehavior : MonoBehaviour
{
    //Color to use for the shader
    public Color color;

    //Texture to use for the shader
    public Texture2D pattern;

    //Refernce to the Renderer Material
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        //Get the material from the Renderer
        material = GetComponent<Renderer>().material;

        //Set the texture
        material.SetTexture("Pattern", pattern);

        //Set the color
        material.SetColor("ColorBlend", color);
    }
}
