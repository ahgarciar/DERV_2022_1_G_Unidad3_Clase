using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler_Color : MonoBehaviour
{
    [SerializeField]
    SO_ColorCubo color_cubo;

    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.color = color_cubo.c_color;
    }
}
