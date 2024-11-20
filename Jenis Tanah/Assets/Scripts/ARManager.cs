using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ARManager : MonoBehaviour
{
    [SerializeField] private SoilSO[] soilData;
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject descriptionImage;
    private AudioClip audioClip;
    private int soilSelected;
    public int lenguageID;
    private bool isMusicPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        // mengambil penyimpanan data
        soilSelected = PlayerPrefs.GetInt("SoilSelected");
        Debug.Log(soilSelected);
        lenguageID = PlayerPrefs.GetInt("LocaleKey");
        if (lenguageID == 0)
        {
            IndonesiaVersion();
        }
        else
        {
            EnglishVersion();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IndonesiaVersion() // fungsi menampilkan bahasa indonesia
    {
        titleText.text = soilData[soilSelected].namaTanah;
        descriptionText.text = soilData[soilSelected].deskripsiTanah;
        audioClip = soilData[soilSelected].suaraPenjelasanTanah;
    }

    void EnglishVersion() // fungsi menampilkan bahasa inggirs
    {
        titleText.text = soilData[soilSelected].soilName;
        descriptionText.text = soilData[soilSelected].soilDescription;
        audioClip = soilData[soilSelected].soilSoundDescription;
    }

    public void ToggleMusic() // fungsi untuk mengeluarkan suara
    {
        if (isMusicPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.PlayOneShot(audioClip);
        }

        isMusicPlaying = !isMusicPlaying; // Mengubah status pemutaran musik
    }
    public void ToggleDescription() // fungsi untuk menampilkan deskripsi
    {
        if (descriptionImage.activeSelf) // Periksa apakah descriptionImage sedang aktif
        {
            descriptionImage.SetActive(false); // Jika aktif, nonaktifkan
        }
        else
        {
            descriptionImage.SetActive(true); // Jika tidak aktif, aktifkan
        }
    }
}
