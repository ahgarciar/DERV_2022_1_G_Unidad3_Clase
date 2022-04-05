using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioPersonajes : MonoBehaviour
{
    [SerializeField]
    public Personaje []personajes;

    public int index_actual;

    [SerializeField]
    GameObject imagen;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        index_actual = -1;
        image = imagen.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (index_actual >= 1) {
                index_actual--;
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (index_actual < personajes.Length) {
                index_actual++;
            }
        }

        if (index_actual != -1) {
            image.sprite = personajes[index_actual].foto;
        }        

    }
}
