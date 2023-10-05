using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public Image FadeObject;
    public Color FadeImage;
    private float fadeTime;
    private AudioSource Clip;
    private bool fade = true;
    // Start is called before the first frame update
    void Start()
    {
        if(FadeObject != null)
        {
            fadeTime = FadeObject.color.a;
            FadeImage = FadeObject.color;

        }

        InstantiateAnimalInfo();
        if (GetComponent<AudioSource>() != null)
        {
            Clip = GetComponent<AudioSource>();
            Clip.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(fade == true)
        {
            if (fadeTime > 0)
            {
                fadeTime -= 0.05f;
                FadeImage.a = fadeTime;
                FadeObject.color = FadeImage;
            }
            else
            {
                Destroy(FadeObject);
                fade = false;
            }
        }
    }

    public void MoveToGameScene()
    {
        if (GetComponent<AudioSource>() != null)
        {
            Clip.Stop();
        }
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

    private void InstantiateAnimalInfo()
    {
        //Cat
        PlayerPrefs.SetString("MaleCat", "Tomcat");
        PlayerPrefs.SetString("FemaleCat", "Queen");
        PlayerPrefs.SetString("YoungCat", "Kitten");
        PlayerPrefs.SetString("GroupCat", "Clowder");
        PlayerPrefs.SetString("SoundCat", "Meow");
        PlayerPrefs.SetString("SNameCat", "Felis catus");
        PlayerPrefs.SetString("DNameCat", "Cat");
        PlayerPrefs.SetString("ClassCat", "Mammalia");

        //Dog
        PlayerPrefs.SetString("MaleDog", "Stud");
        PlayerPrefs.SetString("FemaleDog", "Bitch");
        PlayerPrefs.SetString("YoungDog", "Puppy");
        PlayerPrefs.SetString("GroupDog", "Pack");
        PlayerPrefs.SetString("SoundDog", "Bark");
        PlayerPrefs.SetString("SNameDog", "Canis lupus Familiaris");
        PlayerPrefs.SetString("DNameDog", "Dog");
        PlayerPrefs.SetString("ClassDog", "Mammalia");

        //Elephant
        PlayerPrefs.SetString("MaleElephant", "Bull");
        PlayerPrefs.SetString("FemaleElephant", "Cow");
        PlayerPrefs.SetString("YoungElephant", "Calf");
        PlayerPrefs.SetString("GroupElephant", "Herd");
        PlayerPrefs.SetString("SoundElephant", "Trumpet");
        PlayerPrefs.SetString("SNameElephant", "Elephas maximus");
        PlayerPrefs.SetString("DNameElephant", "Elephant");
        PlayerPrefs.SetString("ClassElephant", "Mammalia");

        //Cow
        PlayerPrefs.SetString("MaleCow", "Bull");
        PlayerPrefs.SetString("FemaleCow", "Cow");
        PlayerPrefs.SetString("YoungCow", "Calf");
        PlayerPrefs.SetString("GroupCow", "Herd");
        PlayerPrefs.SetString("SoundCow", "Moo");
        PlayerPrefs.SetString("SNameCow", "Bos taurus");
        PlayerPrefs.SetString("DNameCow", "Cow");
        PlayerPrefs.SetString("ClassCow", "Mammalia");

        //Chicken
        PlayerPrefs.SetString("MaleChicken", "Rooster");
        PlayerPrefs.SetString("FemaleChicken", "Hen");
        PlayerPrefs.SetString("YoungChicken", "Chick");
        PlayerPrefs.SetString("GroupChicken", "Flock");
        PlayerPrefs.SetString("SoundChicken", "Cluck");
        PlayerPrefs.SetString("SNameChicken", "Gallus gallus domesticus");
        PlayerPrefs.SetString("DNameChicken", "Chicken");
        PlayerPrefs.SetString("ClassChicken", "Aves");

        //Frog
        PlayerPrefs.SetString("MaleFrog", "Frog");
        PlayerPrefs.SetString("FemaleFrog", "Frog");
        PlayerPrefs.SetString("YoungFrog", "Tadpole");
        PlayerPrefs.SetString("GroupFrog", "Army");
        PlayerPrefs.SetString("SoundFrog", "Croak");
        PlayerPrefs.SetString("SNameFrog", "Anura");
        PlayerPrefs.SetString("DNameFrog", "Frog");
        PlayerPrefs.SetString("ClassFrog", "Amphibians");

        //Lion
        PlayerPrefs.SetString("MaleLion", "Lion");
        PlayerPrefs.SetString("FemaleLion", "Lioness");
        PlayerPrefs.SetString("YoungLion", "Cub");
        PlayerPrefs.SetString("GroupLion", "Pride");
        PlayerPrefs.SetString("SoundLion", "Roar");
        PlayerPrefs.SetString("SNameLion", "Panthera leo");
        PlayerPrefs.SetString("DNameLion", "Lion");
        PlayerPrefs.SetString("ClassLion", "Mammalia");

        //Monkey
        PlayerPrefs.SetString("MaleMonkey", "Monkey");
        PlayerPrefs.SetString("FemaleMonkey", "Monkey");
        PlayerPrefs.SetString("YoungMonkey", "Infant");
        PlayerPrefs.SetString("GroupMonkey", "Troop");
        PlayerPrefs.SetString("SoundMonkey", "Chatter");
        PlayerPrefs.SetString("SNameMokey", "Cercopithecidae");
        PlayerPrefs.SetString("DNameMonkey", "Monkey");
        PlayerPrefs.SetString("ClassMonkey", "Mammalia");

        //Pig
        PlayerPrefs.SetString("MalePig", "Boar");
        PlayerPrefs.SetString("FemalePig", "Sow");
        PlayerPrefs.SetString("YoungPig", "Piglet");
        PlayerPrefs.SetString("GroupPig", "Drift");
        PlayerPrefs.SetString("SoundPig", "Oink");
        PlayerPrefs.SetString("SNamePig", "Sus scrofa domesticus");
        PlayerPrefs.SetString("DNamePig", "Pig");
        PlayerPrefs.SetString("ClassPig", "Mammalia");

        //Snake
        PlayerPrefs.SetString("MaleSnake", "Snake");
        PlayerPrefs.SetString("FemaleSnake", "Snake");
        PlayerPrefs.SetString("YoungSnake", "Snakelet");
        PlayerPrefs.SetString("GroupSnake", "Den");
        PlayerPrefs.SetString("SoundSnake", "Hiss");
        PlayerPrefs.SetString("SNameSnake", "Serpentes");
        PlayerPrefs.SetString("DNameSnake", "Snake");
        PlayerPrefs.SetString("ClassSnake", "Reptilia");

        //Goat
        PlayerPrefs.SetString("MaleGoat", "Buck");
        PlayerPrefs.SetString("FemaleGoat", "Doe");
        PlayerPrefs.SetString("YoungGoat", "Kid");
        PlayerPrefs.SetString("GroupGoat", "Tribe");
        PlayerPrefs.SetString("SoundGoat", "Bleat");
        PlayerPrefs.SetString("SNameGoat", "Capra aegagrus hircus");
        PlayerPrefs.SetString("DNameGoat", "Goat");
        PlayerPrefs.SetString("ClassGoat", "Mammalia");

        //Eagle
        PlayerPrefs.SetString("MaleEagle", "Eagle");
        PlayerPrefs.SetString("FemaleEagle", "Eagle");
        PlayerPrefs.SetString("YoungEagle", "Eaglet");
        PlayerPrefs.SetString("GroupEagle", "Convocation");
        PlayerPrefs.SetString("SoundEagle", "Screech");
        PlayerPrefs.SetString("SNameEagle", "Accipitridae");
        PlayerPrefs.SetString("DNameEagle", "Eagle");
        PlayerPrefs.SetString("ClassEagle", "Aves");

        //Duck
        PlayerPrefs.SetString("MaleDuck", "Drake");
        PlayerPrefs.SetString("FemaleDuck", "Duck");
        PlayerPrefs.SetString("YoungDuck", "Duckling");
        PlayerPrefs.SetString("GroupDuck", "Flock");
        PlayerPrefs.SetString("SoundDuck", "Quack");
        PlayerPrefs.SetString("SNameDuck", "Anas platyrhynchos domesticus");
        PlayerPrefs.SetString("DNameDuck", "Duck");
        PlayerPrefs.SetString("ClassDuck", "Aves");

        //Seal
        PlayerPrefs.SetString("MaleSeal", "Bull");
        PlayerPrefs.SetString("FemaleSeal", "Cow");
        PlayerPrefs.SetString("YoungSeal", "Pup");
        PlayerPrefs.SetString("GroupSeal", "Colony");
        PlayerPrefs.SetString("SoundSeal", "Bark");
        PlayerPrefs.SetString("SNameSeal", "Phocidae");
        PlayerPrefs.SetString("DNameSeal", "Seal");
        PlayerPrefs.SetString("ClassSeal", "Mammalia");

        //Wolf
        PlayerPrefs.SetString("MaleWolf", "Wolf");
        PlayerPrefs.SetString("FemaleWolf", "She-Wolf");
        PlayerPrefs.SetString("YoungWolf", "Pup");
        PlayerPrefs.SetString("GroupWolf", "Pack");
        PlayerPrefs.SetString("SoundWolf", "Howl");
        PlayerPrefs.SetString("SNameWolf", "Canis lupus");
        PlayerPrefs.SetString("DNameWolf", "Wolf");
        PlayerPrefs.SetString("ClassWolf", "Mammalia");

        //Whale
        PlayerPrefs.SetString("MaleWhale", "Bull");
        PlayerPrefs.SetString("FemaleWhale", "Cow");
        PlayerPrefs.SetString("YoungWhale", "Calf");
        PlayerPrefs.SetString("GroupWhale", "Pod");
        PlayerPrefs.SetString("SoundWhale", "Singing");
        PlayerPrefs.SetString("SNameWhale", "Cetacea");
        PlayerPrefs.SetString("DNameWhale", "Whale");
        PlayerPrefs.SetString("ClassWhale", "Mammalia");

        //Horse
        PlayerPrefs.SetString("MaleHorse", "Stallion");
        PlayerPrefs.SetString("FemaleHorse", "Mare");
        PlayerPrefs.SetString("YoungHorse", "Foal");
        PlayerPrefs.SetString("GroupHorse", "Herd");
        PlayerPrefs.SetString("SoundHorse", "Neigh");
        PlayerPrefs.SetString("SNameHorse", "Equus ferus caballus");
        PlayerPrefs.SetString("DNameHorse", "Horse");
        PlayerPrefs.SetString("ClassHorse", "Mamalia");
    }
}
