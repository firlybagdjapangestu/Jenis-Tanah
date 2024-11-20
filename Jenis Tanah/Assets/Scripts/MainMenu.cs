using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int selectedSoil;
    [SerializeField] private SoilSO[] soilData;
    [SerializeField] private Image panelAR;
    public void SelectSoil(int indexSoil)
    {
        selectedSoil = indexSoil;
        PlayerPrefs.SetInt("SoilSelected", selectedSoil);
    }

    public void ChangeData()
    {
        panelAR.sprite = soilData[selectedSoil].soilImage;
    }
}
