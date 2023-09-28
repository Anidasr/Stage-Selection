using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    public ScriptScene scriptScene;

    public void nextStage(string key)
    {
        // Periksa apakah stage sudah terbuka sebelumnya
        int status = PlayerPrefs.GetInt(key, 0); // Default value 0 jika "key" belum ada

        if (status != 1)
        {
            // Jika belum terbuka, maka set sebagai terbuka
            PlayerPrefs.SetInt(key, 1);
            PlayerPrefs.Save(); // Simpan perubahan ke PlayerPrefs
        }

        scriptScene.PindahScene("StageSelection");
    }
}
