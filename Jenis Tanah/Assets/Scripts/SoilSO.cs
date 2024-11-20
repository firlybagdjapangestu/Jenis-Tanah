using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Soil", menuName = "Soil Data", order = 1)]
public class SoilSO : ScriptableObject
{
    public Sprite soilImage;
    public string soilName;
    [TextArea(3, 5)]
    public string soilDescription;
    public AudioClip soilSoundDescription;

    public string namaTanah;
    [TextArea(3, 5)]
    public string deskripsiTanah;
    public AudioClip suaraPenjelasanTanah;

    public GameObject soilPrefabs;
}
