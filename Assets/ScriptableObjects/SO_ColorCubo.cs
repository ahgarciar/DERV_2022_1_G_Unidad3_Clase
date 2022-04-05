using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CambioColor_", menuName = "Colores_Materials/CambiaColor", order = 1)]
public class SO_ColorCubo : ScriptableObject
{
    [SerializeField]
    public Material c_material;

    [SerializeField]
    public Color c_color;


}
