using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private AudioSource Clip;
    // Start is called before the first frame update
    void Start()
    {
        if(GetComponent<AudioSource>() != null)
        {
            Clip = GetComponent<AudioSource>();
            Clip.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToGameScene()
    {
        Clip.Pause();
        SceneManager.LoadScene("GameScene");
    }

    public void MoveToMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
        Invoke("PlaySound", 3f);
    }

    public void Quit()
    {
        Clip.Stop();
        Application.Quit();
    }

    private void PlaySound()
    {
        Clip.Play();
    }
}
