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

    public TextMeshProUGUI LevelsText;
    private int Level;

    public GameObject OptionButtom;

    public float VolumeValue;

    public TMP_InputField UsernameText;

    public TextMeshProUGUI DificultyText;
    private bool HardMode;



    // Start is called before the first frame update
    void Start()
    {
        OptionButtom.SetActive(false); //Por defecto esta activado el panel del menu

        LevelsText.text = "Level: " + Level;
    }

    public void Options()
    {
        OptionButtom.SetActive(true); //Cuando clicamos el boton de options se instancia el panel de options
    }

    public void Exit()
    {
        OptionButtom.SetActive(false); //Cuando clicamos el boton de exit se activa el panel del menu
    }

    //Funciones para acceder a los botones
    public void Level1()
    {
        Level = 1;
        LevelsText.text = "Level: " + Level;
    }

    public void Level2()
    {
        Level = 2;
        LevelsText.text = "Level: " + Level;
    }

    public void Level3()
    {
        Level = 3;
        LevelsText.text = "Level: " + Level;
    }

    public void ToggleFun(bool b)
    {
        if (b)
        {
            HardMode = true;           
        }
        else
        {
            HardMode = false;
        }
    }

    public void Volume(float volume)
    {
        VolumeValue = volume;
    }

    public void SaveUserOptions()
    {
        // Persistencia de datos entre escenas
        DataPersistence.sharedInstance.Level = Level;

        DataPersistence.sharedInstance.HardMode = HardMode;

        DataPersistence.sharedInstance.UsernameText = UsernameText.text;

        DataPersistence.sharedInstance.VolumeValue = VolumeValue;

        // Persistencia de datos entre partidas
        DataPersistence.sharedInstance.SaveForFutureGames();
    }

    public void LoadUserOptions()
    {
        // Tal y como lo hemos configurado, si tiene esta clave, entonces tiene todas
        if (PlayerPrefs.HasKey("LEVEL"))
        {

            Level = PlayerPrefs.GetInt("LEVEL");
            UpdateLevel();

            UsernameText.text = PlayerPrefs.GetString("USERNAME");

            VolumeValue = PlayerPrefs.GetFloat("VOLUMEVALUE");

            //HardMode = PlayerPrefs.GetBool("MODE");
        }
    }

    private void UpdateLevel()
    {
        LevelsText.text = "Level: " + Level;
    }

}



