using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EduAI : MonoBehaviour
{
    public Text Name;
    public Text Male;
    public Text Female;
    public Text Child;
    public Text Group;
    public Text Sound;
    public Text SName;
    public Text Class;

    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    public Sprite Image7;
    public Sprite Image8;
    public Sprite Image9;
    public Sprite Image10;

    public Sprite CatSprite;
    public Sprite DogSprite;
    public Sprite ElephantSprite;
    public Sprite CowSprite;
    public Sprite ChickenSprite;
    public Sprite FrogSprite;
    public Sprite LionSprite;
    public Sprite MonkeySprite;
    public Sprite PigSprite;
    public Sprite SnakeSprite;
    public Sprite GoatSprite;
    public Sprite EagleSprite;
    public Sprite DuckSprite;
    public Sprite SealSprite;
    public Sprite WolfSprite;
    public Sprite WhaleSprite;
    public Sprite HorseSprite;

    private int Index = 0;
    private int StudyIndex = 0;
    public Image Image;
    private bool StopSilouhette = false;
    private AudioSource SoundManager;
    public AudioClip Twinkle;
    private StarScript SSCript;
    public GameObject NextButton;
    // Start is called before the first frame update
    void Start()
    {
        SSCript = FindAnyObjectByType<StarScript>();
        SoundManager = GetComponent<AudioSource>();
        Invoke("DisplayCaseStudy", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(StopSilouhette == false)
        {
            Index = Random.Range(1, 11);
            DetSilouhette();
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            DisplayCaseStudy();
        }

    }

    private void DetSilouhette()
    {
        if (Index == 1)
        {
            Image.sprite = Image1;
        }
        else if (Index == 2)
        {
            Image.sprite = Image2;
        }
        else if (Index == 3)
        {
            Image.sprite = Image3;
        }
        else if (Index == 4)
        {
            Image.sprite = Image4;
        }
        else if (Index == 5)
        {
            Image.sprite = Image5;
        }
        else if (Index == 6)
        {
            Image.sprite = Image6;
        }
        else if (Index == 7)
        {
            Image.sprite = Image7;
        }
        else if (Index == 8)
        {
            Image.sprite = Image8;
        }
        else if (Index == 9)
        {
            Image.sprite = Image9;
        }
        else if (Index == 10)
        {
            Image.sprite = Image10;
        }
    }

    private void DisplayCaseStudy()
    {
        SSCript.DisplayStars();
        StopSilouhette = true;
        SoundManager.clip = Twinkle;
        SoundManager.Play();
        StudyIndex = Random.Range(1, 18);
        if (StudyIndex == 1)
        {
            Image.sprite = CatSprite;
            Male.text = PlayerPrefs.GetString("MaleCat");
            Female.text = PlayerPrefs.GetString("FemaleCat");
            Child.text = PlayerPrefs.GetString("YoungCat");
            Group.text = PlayerPrefs.GetString("GroupCat");
            Sound.text = PlayerPrefs.GetString("SoundCat");
            SName.text  = PlayerPrefs.GetString("SNameCat");
            Name.text = PlayerPrefs.GetString("DNameCat");
            Class.text = PlayerPrefs.GetString("ClassCat");
        }
        else if (StudyIndex == 2)
        {
            Image.sprite = DogSprite;
            Male.text = PlayerPrefs.GetString("MaleDog");
            Female.text = PlayerPrefs.GetString("FemaleDog");
            Child.text = PlayerPrefs.GetString("YoungDog");
            Group.text = PlayerPrefs.GetString("GroupDog");
            Sound.text = PlayerPrefs.GetString("SoundDog");
            SName.text = PlayerPrefs.GetString("SNameDog");
            Name.text = PlayerPrefs.GetString("DNameDog");
            Class.text = PlayerPrefs.GetString("ClassDog");
        }
        else if (StudyIndex == 3)
        {
            Image.sprite = ElephantSprite;
            Male.text = PlayerPrefs.GetString("MaleElephant");
            Female.text = PlayerPrefs.GetString("FemaleElephant");
            Child.text = PlayerPrefs.GetString("YoungElephant");
            Group.text = PlayerPrefs.GetString("GroupElephant");
            Sound.text = PlayerPrefs.GetString("SoundElephant");
            SName.text = PlayerPrefs.GetString("SNameElephant");
            Name.text = PlayerPrefs.GetString("DNameElephant");
            Class.text = PlayerPrefs.GetString("ClassElephant");
        }
        else if (StudyIndex == 4)
        {
            Image.sprite = CowSprite;
            Male.text = PlayerPrefs.GetString("MaleCow");
            Female.text = PlayerPrefs.GetString("FemaleCow");
            Child.text = PlayerPrefs.GetString("YoungCow");
            Group.text = PlayerPrefs.GetString("GroupCow");
            Sound.text = PlayerPrefs.GetString("SoundCow");
            SName.text = PlayerPrefs.GetString("SNameCow");
            Name.text = PlayerPrefs.GetString("DNameCow");
            Class.text = PlayerPrefs.GetString("ClassCow");
        }
        else if (StudyIndex == 5)
        {
            Image.sprite = ChickenSprite;
            Male.text = PlayerPrefs.GetString("MaleChicken");
            Female.text = PlayerPrefs.GetString("FemaleChicken");
            Child.text = PlayerPrefs.GetString("YoungChicken");
            Group.text = PlayerPrefs.GetString("GroupChicken");
            Sound.text = PlayerPrefs.GetString("SoundChicken");
            SName.text = PlayerPrefs.GetString("SNameChicken");
            Name.text = PlayerPrefs.GetString("DNameChicken");
            Class.text = PlayerPrefs.GetString("ClassChicken");
        }
        else if (StudyIndex == 6)
        {
            Image.sprite = FrogSprite;
            Male.text = PlayerPrefs.GetString("MaleFrog");
            Female.text = PlayerPrefs.GetString("FemaleFrog");
            Child.text = PlayerPrefs.GetString("YoungFrog");
            Group.text = PlayerPrefs.GetString("GroupFrog");
            Sound.text = PlayerPrefs.GetString("SoundFrog");
            SName.text = PlayerPrefs.GetString("SNameFrog");
            Name.text = PlayerPrefs.GetString("DNameFrog");
            Class.text = PlayerPrefs.GetString("ClassFrog");
        }
        else if (StudyIndex == 7)
        {
            Image.sprite = LionSprite;
            Male.text = PlayerPrefs.GetString("MaleLion");
            Female.text = PlayerPrefs.GetString("FemaleLion");
            Child.text = PlayerPrefs.GetString("YoungLion");
            Group.text = PlayerPrefs.GetString("GroupLion");
            Sound.text = PlayerPrefs.GetString("SoundLion");
            SName.text = PlayerPrefs.GetString("SNameLion");
            Name.text = PlayerPrefs.GetString("DNameLion");
            Class.text = PlayerPrefs.GetString("ClassLion");
        }
        else if (StudyIndex == 8)
        {
            Image.sprite = MonkeySprite;
            Male.text = PlayerPrefs.GetString("MaleMonkey");
            Female.text = PlayerPrefs.GetString("FemaleMonkey");
            Child.text = PlayerPrefs.GetString("YoungMonkey");
            Group.text = PlayerPrefs.GetString("GroupMonkey");
            Sound.text = PlayerPrefs.GetString("SoundMonkey");
            SName.text = PlayerPrefs.GetString("SNameMokey");
            Name.text = PlayerPrefs.GetString("DNameMonkey");
            Class.text = PlayerPrefs.GetString("ClassMonkey");
        }
        else if (StudyIndex == 9)
        {
            Image.sprite = PigSprite;
            Male.text = PlayerPrefs.GetString("MalePig");
            Female.text = PlayerPrefs.GetString("FemalePig");
            Child.text = PlayerPrefs.GetString("YoungPig");
            Group.text = PlayerPrefs.GetString("GroupPig");
            Sound.text = PlayerPrefs.GetString("SoundPig");
            SName.text = PlayerPrefs.GetString("SNamePig");
            Name.text = PlayerPrefs.GetString("DNamePig");
            Class.text = PlayerPrefs.GetString("ClassPig");
        }
        else if (StudyIndex == 10)
        {
            Image.sprite = SnakeSprite;
            Male.text = PlayerPrefs.GetString("MaleSnake");
            Female.text = PlayerPrefs.GetString("FemaleSnake");
            Child.text = PlayerPrefs.GetString("YoungSnake");
            Group.text = PlayerPrefs.GetString("GroupSnake");
            Sound.text = PlayerPrefs.GetString("SoundSnake");
            SName.text = PlayerPrefs.GetString("SNameSnake");
            Name.text = PlayerPrefs.GetString("DNameSnake");
            Class.text = PlayerPrefs.GetString("ClassSnake");
        }
        else if (StudyIndex == 11)
        {
            Image.sprite = GoatSprite;
            Male.text = PlayerPrefs.GetString("MaleGoat");
            Female.text = PlayerPrefs.GetString("FemaleGoat");
            Child.text = PlayerPrefs.GetString("YoungGoat");
            Group.text = PlayerPrefs.GetString("GroupGoat");
            Sound.text = PlayerPrefs.GetString("SoundGoat");
            SName.text = PlayerPrefs.GetString("SNameGoat");
            Name.text = PlayerPrefs.GetString("DNameGoat");
            Class.text = PlayerPrefs.GetString("ClassGoat");
        }
        else if (StudyIndex == 12)
        {
            Image.sprite = EagleSprite;
            Male.text = PlayerPrefs.GetString("MaleEagle");
            Female.text = PlayerPrefs.GetString("FemaleEagle");
            Child.text = PlayerPrefs.GetString("YoungEagle");
            Group.text = PlayerPrefs.GetString("GroupEagle");
            Sound.text = PlayerPrefs.GetString("SoundEagle");
            SName.text = PlayerPrefs.GetString("SNameEagle");
            Name.text = PlayerPrefs.GetString("DNameEagle");
            Class.text = PlayerPrefs.GetString("ClassEagle");
        }
        else if (StudyIndex == 13)
        {
            Image.sprite = DuckSprite;
            Male.text = PlayerPrefs.GetString("MaleDuck");
            Female.text = PlayerPrefs.GetString("FemaleDuck");
            Child.text = PlayerPrefs.GetString("YoungDuck");
            Group.text = PlayerPrefs.GetString("GroupDuck");
            Sound.text = PlayerPrefs.GetString("SoundDuck");
            SName.text = PlayerPrefs.GetString("SNameDuck");
            Name.text = PlayerPrefs.GetString("DNameDuck");
            Class.text = PlayerPrefs.GetString("ClassDuck");
        }
        else if (StudyIndex == 14)
        {
            Image.sprite = SealSprite;
            Male.text = PlayerPrefs.GetString("MaleSeal");
            Female.text = PlayerPrefs.GetString("FemaleSeal");
            Child.text = PlayerPrefs.GetString("YoungSeal");
            Group.text = PlayerPrefs.GetString("GroupSeal");
            Sound.text = PlayerPrefs.GetString("SoundSeal");
            SName.text = PlayerPrefs.GetString("SNameSeal");
            Name.text = PlayerPrefs.GetString("DNameSeal");
            Class.text = PlayerPrefs.GetString("ClassSeal");
        }
        else if (StudyIndex == 15)
        {
            Image.sprite = WolfSprite;
            Male.text = PlayerPrefs.GetString("MaleWolf");
            Female.text = PlayerPrefs.GetString("FemaleWolf");
            Child.text = PlayerPrefs.GetString("YoungWolf");
            Group.text = PlayerPrefs.GetString("GroupWolf");
            Sound.text = PlayerPrefs.GetString("SoundWolf");
            SName.text = PlayerPrefs.GetString("SNameWolf");
            Name.text = PlayerPrefs.GetString("DNameWolf");
            Class.text = PlayerPrefs.GetString("ClassWolf");
        }
        else if (StudyIndex == 16)
        {
            Image.sprite = WhaleSprite;
            Male.text = PlayerPrefs.GetString("MaleWhale");
            Female.text = PlayerPrefs.GetString("FemaleWhale");
            Child.text = PlayerPrefs.GetString("YoungWhale");
            Group.text = PlayerPrefs.GetString("GroupWhale");
            Sound.text = PlayerPrefs.GetString("SoundWhale");
            SName.text = PlayerPrefs.GetString("SNameWhale");
            Name.text = PlayerPrefs.GetString("DNameWhale");
            Class.text = PlayerPrefs.GetString("ClassWhale");
        }
        else if (StudyIndex == 17)
        {
            Image.sprite = HorseSprite;
            Male.text = PlayerPrefs.GetString("MaleHorse");
            Female.text = PlayerPrefs.GetString("FemaleHorse");
            Child.text = PlayerPrefs.GetString("YoungHorse");
            Group.text = PlayerPrefs.GetString("GroupHorse");
            Sound.text = PlayerPrefs.GetString("SoundHorse");
            SName.text = PlayerPrefs.GetString("SNameHorse");
            Name.text = PlayerPrefs.GetString("DNameHorse");
            Class.text = PlayerPrefs.GetString("ClassHorse");
        }

        NextButton.SetActive(true);
    }
}
