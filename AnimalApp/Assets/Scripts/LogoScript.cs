using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogoScript : MonoBehaviour
{
    public Image FadeObject;
    public Color FadeImage;
    private float fadeTime;
    // Start is called before the first frame update
    void Start()
    {
        fadeTime = FadeObject.color.a;
        FadeImage = FadeObject.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeTime > 0)
        {
            fadeTime -= 0.01f;
            FadeImage.a = fadeTime;
            FadeObject.color = FadeImage;
        }
        else
        {
            SceneManager.LoadScene("MainMenuScene");
        }
    }
}
