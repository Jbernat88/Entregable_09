using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;

    public TextMeshProUGUI Level;

    public TextMeshProUGUI HardMode;

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
        HardMode.text = $"Hard Mode: {DataPersistence.sharedInstance.HardMode}";
        UsernameText.text = $"Username: {DataPersistence.sharedInstance.UsernameText}";
        VolumeValue.text = $"Volume: { DataPersistence.sharedInstance.VolumeValue}$";
    }


}