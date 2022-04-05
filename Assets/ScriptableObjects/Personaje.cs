using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Personaje_", menuName = "Dialogos/Crear Personaje", order = 1)]
public class Personaje : ScriptableObject
{
    public string nombre;
    public Sprite foto;
}
