using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDialogo : MonoBehaviour
{
    [SerializeField]
    GameObject panel_dialogo;

    // Start is called before the first frame update
    void Start()
    {
        panel_dialogo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) {
            panel_dialogo.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.K)) {
            panel_dialogo.SetActive(false);
        }
    }
}
