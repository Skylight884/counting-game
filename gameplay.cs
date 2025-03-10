using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Gameplay : MonoBehaviour
{

    public string[] soal, jawaban;

    public Text text_soal, text_skor;

    public InputField input_jawaban;

    public GameObject feed_benar, feed_salah, selesai, bank_soal;

    int urutan_soal = -1, skor = 0;
    // Start is called before the first frame update
    void Start()
    {
        tampil_soal();

    }
    void tampil_soal()
    {
        urutan_soal++;
        text_soal.text = soal[urutan_soal];

    }

    public void jawab()
    {
        if (urutan_soal < soal.Length - 1)
        {
            if (input_jawaban.text == jawaban[urutan_soal])
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                skor += 20;
            }
            else
            {
                feed_benar.SetActive(false);
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
                skor += -5;
            }

            input_jawaban.text = "";
            tampil_soal();
        }

        else
        {
            selesai.SetActive(true);
            bank_soal.SetActive(false);
            if (input_jawaban.text == jawaban[urutan_soal])
            {
                skor += 20;
            }
            else
            {
                skor -= 10;
            }

        }

    }


    // Update is called once per frame
    void Update()
    {
        text_skor.text = skor.ToString();
    }

}