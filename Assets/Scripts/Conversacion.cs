using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Conv_", menuName = "Dialogos/Crear Conversacion", order = 2)]
public class Conversacion : ScriptableObject
{
    
    [System.Serializable]
    public struct Dialogo{       
        public Personaje personaje;     
        [TextArea(2, 10)]
        public string dialogo;
    }


    public int contador;

    [SerializeField]
    public Dialogo[] conv;

    public Dialogo getNextMsjIfExists() {
        Dialogo dialogo;
        if (contador < conv.Length)
        {
            dialogo = conv[contador];
        }
        else {
            dialogo = new Dialogo();
            dialogo.dialogo = null;
            return dialogo;
        }
        contador++;
        return dialogo;
    }



}
