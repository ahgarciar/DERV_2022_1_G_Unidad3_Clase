using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorConversacion : MonoBehaviour
{
    [SerializeField]
    public Conversacion conversacion;

    [SerializeField]
    public int tiempo;

    [SerializeField]
    public TextMeshProUGUI msj;

    [SerializeField]
    public Image img;

    [SerializeField]
    public GameObject panel;
  
    // Start is called before the first frame update
    void Start()
    {

        //Conversacion.Dialogo _dialogo = conversacion.getNextMsjIfExists();

        //msj.text = _dialogo.dialogo;
        //img.sprite = _dialogo.personaje.foto;

        Debug.Log("Cant Dialogos: " + conversacion.conv.Length);

        panel.SetActive(true);

        StopAllCoroutines();
        StartCoroutine("conversacionXtiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator conversacionXtiempo() {
        Debug.Log(conversacion.conv.Length);
        //conversacion.conv.Length

        conversacion.contador = 0;
        Debug.Log("Cont Dialogo: " + conversacion.contador);

        for (int i = 0; i < conversacion.conv.Length; i++){

            Conversacion.Dialogo _dialogo = conversacion.getNextMsjIfExists();
            msj.text = _dialogo.dialogo;
            img.sprite = _dialogo.personaje.foto;
            Debug.Log("Valor i: " + i.ToString());
            yield return new WaitForSeconds(1.0f);
        }

        yield return new WaitForSeconds(1.5f);

        panel.SetActive(false);

    }


}
