using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    public AudioSource GenerateAudioSource;

    public TextMeshProUGUI Level;

    public TextMeshProUGUI MusicToggle;

    public TextMeshProUGUI UsernameText;

    public TextMeshProUGUI VolumeValue;


    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        // Aplicamos los cambios guardados en la escena Menu
        ApplyUserOptions();
    }

    public void ApplyUserOptions()
    {
        Level.text = $"Level: { DataPersistence.sharedInstance.Level}";
        MusicToggle.text = $"Music: {DataPersistence.sharedInstance.MusicToggle}";
        UsernameText.text = $"Username: {DataPersistence.sharedInstance.UsernameText}";
        VolumeValue.text = $"Volume: { DataPersistence.sharedInstance.VolumeValue}";

        MusicOnOff();
    }

    public void MusicOnOff() //Cuando Cargamos el juego reproducira la muscia si esta activado el toggle.
    {
        if(DataPersistence.sharedInstance.MusicToggle == 0)
        {
            MusicToggle.text = $"MusicOn:(true)";
            GenerateAudioSource.Play();
        }

        else
        {
            MusicToggle.text = $"MusicOn:(false)";
            GenerateAudioSource.Play();
        }
    }


}