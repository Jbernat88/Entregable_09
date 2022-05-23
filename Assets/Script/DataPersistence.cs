using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{

    public static DataPersistence sharedInstance;

    public int Level;

    public bool HardMode;

    public string UsernameText;

    public float VolumeValue;

    public int MusicToggle;




    // Nos aseguramos de que la instancia sea única
    private void Awake()
    {
        // Si la instancia no existe
        if (sharedInstance == null)
        {
            // Configuramos la instancia
            sharedInstance = this;
            // Nos aseguramos de que no sea destruida con el cambio de escena
            DontDestroyOnLoad(sharedInstance);
        }
        else
        {
            // Como ya existe una instancia, destruimos la copia
            Destroy(this);
        }
    }

    public void SaveForFutureGames()
    {
        // Nivel
        PlayerPrefs.SetInt("LEVEL", Level);

        //PlayerPrefs.SetBool("MODE", HardMode);

        PlayerPrefs.SetString("USERNAME", UsernameText);

        PlayerPrefs.SetFloat("VOLUMEVALUE", VolumeValue);

        PlayerPrefs.SetInt("MUSIC", MusicToggle);
    }


}

