using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoilScript : MonoBehaviour
{
    [SerializeField] private SoilSO[] soilData;
    [SerializeField] private TextMeshProUGUI descriptionText;
    private int soilSelected;
    void Start()
    {
        soilSelected = PlayerPrefs.GetInt("SoilSelected");
        descriptionText.text = soilData[soilSelected].deskripsiTanah;
        GameObject obj = Instantiate(soilData[soilSelected].soilPrefabs, gameObject.transform.position, gameObject.transform.rotation);
        obj.transform.SetParent(gameObject.transform);
    }

    
}
