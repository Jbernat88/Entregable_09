using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using UnityEngine;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsUIMenu : MonoBehaviour
{

    public GameObject OptionButtom;

    // Start is called before the first frame update
    void Start()
    {
        OptionButtom.SetActive(false); //Por defecto esta activado el panel del menu
    }

    public void Options()
    {
        OptionButtom.SetActive(true); //Cuando clicamos el boton de options se instancia el panel de options
    }

    public void Exit()
    {
        OptionButtom.SetActive(false); //Cuando clicamos el boton de exit se activa el panel del menu
    }

}
