using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameAI : MonoBehaviour
{
    public int correctText = 0;
    public int CorrectSprite = 0;
    public int CorrectCounter = 0;
    private int match = 0;
    private string Decision = null;

    private int TempIndex;
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

    private AudioSource MainSound;
    private AudioClip MainClip;

    public AudioClip CatSound;
    public AudioClip DogSound;
    public AudioClip ElephantSound;
    public AudioClip CowSound;
    public AudioClip ChickenSound;
    public AudioClip FrogSound;
    public AudioClip LionSound;
    public AudioClip MonkeySound;
    public AudioClip PigSound;
    public AudioClip SnakeSound;
    public AudioClip GoatSound;
    public AudioClip EagleSound;
    public AudioClip DuckSound;
    public AudioClip SealSound;
    public AudioClip WolfSound;
    public AudioClip WhaleSound;
    public AudioClip HorseSound;

    public GameObject BuzzerObject;

    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;

    public Button Button6;
    public Button Button7;
    public Button Button8;
    public Button Button9;
    public Button Button10;

    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;
    public Text Text5;


    public GameObject Line1_1;
    public GameObject Line1_2;
    public GameObject Line1_3;
    public GameObject Line1_4;
    public GameObject Line1_5;

    public GameObject Line2_1;
    public GameObject Line2_2;
    public GameObject Line2_3;
    public GameObject Line2_4;
    public GameObject Line2_5;

    public GameObject Line3_1;
    public GameObject Line3_2;
    public GameObject Line3_3;
    public GameObject Line3_4;
    public GameObject Line3_5;

    public GameObject Line4_1;
    public GameObject Line4_2;
    public GameObject Line4_3;
    public GameObject Line4_4;
    public GameObject Line4_5;

    public GameObject Line5_1;
    public GameObject Line5_2;
    public GameObject Line5_3;
    public GameObject Line5_4;
    public GameObject Line5_5;


    public GameObject ParticlePrefab;
    //public GameObject Particles;
    //private GameObject ParticleObject;
    private int ACounter = 0;
    private float colorDensity = 0.5f;
    private Color WinImage;
    private Image CurrentImage;
    private Text CurrentText;
    public List<string> AnimalList = new List<string>();
    private List<AudioClip> AudioList = new List<AudioClip>();
    public List<int> TempList = new List<int>();
    public List<int> TempList2 = new List<int>();
    private List<Sprite> ImageList = new List<Sprite>();
    private List<Button> ButtonList = new List<Button>();
    private List<Button> ButtonList2 = new List<Button>();
    private List<Text> TextList = new List<Text>();
    private List<GameObject> LineList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        MainSound = GetComponent<AudioSource>();
        MainClip = MainSound.GetComponent<AudioClip>();


        AnimalList.Add("Cat");
        AnimalList.Add("Dog");
        AnimalList.Add("Elephant");
        AnimalList.Add("Cow");
        AnimalList.Add("Chicken");
        AnimalList.Add("Frog");
        AnimalList.Add("Lion");
        AnimalList.Add("Monkey");
        AnimalList.Add("Pig");
        AnimalList.Add("Snake");
        AnimalList.Add("Goat");
        AnimalList.Add("Eagle");
        AnimalList.Add("Duck");
        AnimalList.Add("Seal");
        AnimalList.Add("Whale");
        AnimalList.Add("Wolf");
        AnimalList.Add("Horse");

        ImageList.Add(CatSprite);
        ImageList.Add(DogSprite);
        ImageList.Add(ElephantSprite);
        ImageList.Add(CowSprite);
        ImageList.Add(ChickenSprite);
        ImageList.Add(FrogSprite);
        ImageList.Add(LionSprite);
        ImageList.Add(MonkeySprite);
        ImageList.Add (PigSprite);
        ImageList.Add(SnakeSprite);
        ImageList.Add(GoatSprite);
        ImageList.Add(EagleSprite);
        ImageList.Add(DuckSprite);
        ImageList.Add(SealSprite);
        ImageList.Add(WhaleSprite);
        ImageList.Add(WolfSprite);
        ImageList.Add(HorseSprite);


        AudioList.Add(CatSound);
        AudioList.Add(DogSound);
        AudioList.Add(ElephantSound);
        AudioList.Add(CowSound);
        AudioList.Add(ChickenSound);
        AudioList.Add(FrogSound);
        AudioList.Add(LionSound);
        AudioList.Add(MonkeySound);
        AudioList.Add(PigSound);
        AudioList.Add(SnakeSound);
        AudioList.Add(GoatSound);
        AudioList.Add(EagleSound);
        AudioList.Add(DuckSound);
        AudioList.Add(SealSound);
        AudioList.Add(WhaleSound);
        AudioList.Add(WolfSound);
        AudioList.Add(HorseSound);

        ButtonList.Add(Button1);
        ButtonList.Add(Button2);
        ButtonList.Add(Button3);
        ButtonList.Add(Button4);
        ButtonList.Add(Button5);

        ButtonList2.Add(Button6);
        ButtonList2.Add(Button7);
        ButtonList2.Add(Button8);
        ButtonList2.Add(Button9);
        ButtonList2.Add(Button10);

        TextList.Add(Text1);
        TextList.Add(Text2);
        TextList.Add(Text3);
        TextList.Add(Text4);
        TextList.Add(Text5);

        LineList.Add(Line1_1);
        LineList.Add(Line1_2);
        LineList.Add(Line1_3);
        LineList.Add(Line1_4);
        LineList.Add(Line1_5);
        
        LineList.Add(Line2_1);
        LineList.Add(Line2_2);
        LineList.Add(Line2_3);
        LineList.Add(Line2_4);
        LineList.Add(Line2_5);
        
        LineList.Add(Line3_1);
        LineList.Add(Line3_2);
        LineList.Add(Line3_3);
        LineList.Add(Line3_4);
        LineList.Add(Line3_5);
        
        LineList.Add(Line4_1);
        LineList.Add(Line4_2);
        LineList.Add(Line4_3);
        LineList.Add(Line4_4);
        LineList.Add(Line4_5);

        LineList.Add(Line5_1);
        LineList.Add(Line5_2);
        LineList.Add(Line5_3);
        LineList.Add(Line5_4);
        LineList.Add(Line5_5);



        while (ACounter < 5)
        {
            TempIndex = Random.Range(0, 17);
            if (!TempList.Contains(TempIndex))
            {
                CurrentImage = ButtonList[ACounter].GetComponent<Image>();
                CurrentImage.sprite = ImageList[TempIndex];
                TempList.Add(TempIndex);
                TempList2.Add(TempIndex);
                ACounter++;
            }
        }
        string TempName;
        TempList.Sort();
        ACounter = 0;
        //Debug.Log(AnimalList[TempList[ACounter]]);
        while (ACounter < 5)
        {
            CurrentText = TextList[ACounter].GetComponent<Text>();
            TempName = AnimalList[TempList[ACounter]];
            CurrentText.text = TempName;
            ACounter++;
            
        }
        
    }


    // Update is called once per frame
    private void Update()
    {
        if(CorrectCounter == 2)
        {
            if(AnimalList[TempList2[CorrectSprite]].Equals(AnimalList[TempList[correctText]]))
            {
                MainClip = AudioList[TempList[correctText]];
                MainSound.clip = MainClip;
                MainSound.Play();
                match++;
                Decision = "Correct";
                Debug.Log("Correct");
                Validation(CorrectSprite, correctText);
                // blur button
                WinImage = ButtonList[CorrectSprite].image.color;
                WinImage.a = colorDensity;
                ButtonList[CorrectSprite].image.color = WinImage;
                // blur text
                WinImage = ButtonList2[correctText].image.color;
                WinImage.a = colorDensity;
                ButtonList2[correctText].image.color = WinImage;

                CorrectCounter = 0;
                

            }
            else
            {
                Handheld.Vibrate();
                Decision = "InCorrect";
                Debug.Log("InCorrect");
                BuzzerObject.GetComponent<AudioSource>().Play();
                Validation(CorrectSprite, correctText);
                Debug.Log(CorrectSprite + " , " +  correctText + " , " + Decision + " , " + AnimalList[TempList2[CorrectSprite]]  + " , " + AnimalList[TempList[correctText]]);
                CorrectCounter = 0;
                //EnableButtons();
                //EnableText();
            }
        }


        if(match == 5)
        {
            //ParticleObject = Instantiate(ParticlePrefab, Particles.transform.position, Quaternion.identity);
            //ParticleObject = Instantiate(ParticlePrefab, Particles.transform.position, Quaternion.identity);
            ParticlePrefab.SetActive(true);
            Invoke("CallEduScene", 2f);
            //Invoke("Restart", 1f);
            match = 0;
        }


        
    }

    void CallEduScene()
    {
        SceneManager.LoadScene("EduScene");
    }

    void Validation(int Animal, int Text)
    {
        // Button 1 - 1
        if(Animal == 0 && Text == 0 && Decision.Equals("Correct"))
        {
            Line1_1.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if(Animal == 0 && Text == 0 && Decision.Equals("InCorrect"))
        {
            Line1_1.SetActive(true);
            Line1_1.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line1_1));
        }

        // Button 1 - 2
        if (Animal == 0 && Text == 1 && Decision.Equals("Correct"))
        {
            Line1_2.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 0 && Text == 1 && Decision.Equals("InCorrect"))
        {
            Line1_2.SetActive(true);
            Line1_2.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line1_2));
        }

        // Button 1 - 3
        if (Animal == 0 && Text == 2 && Decision.Equals("Correct"))
        {
            Line1_3.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 0 && Text == 2 && Decision.Equals("InCorrect"))
        {
            Line1_3.SetActive(true);
            Line1_3.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line1_3));
        }

        // Button 1 - 4
        if (Animal == 0 && Text == 3 && Decision.Equals("Correct"))
        {
            Line1_4.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 0 && Text == 3 && Decision.Equals("InCorrect"))
        {
            Line1_4.SetActive(true);
            Line1_4.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line1_4));
        }

        // Button 1 - 5
        if (Animal == 0 && Text == 4 && Decision.Equals("Correct"))
        {
            Line1_5.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 0 && Text == 4 && Decision.Equals("InCorrect"))
        {
            Line1_5.SetActive(true);
            Line1_5.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line1_5));
        }

        ///////////////////////////////////////////////////////////////////////////

        // Button 2 - 1
        if (Animal == 1 && Text == 0 && Decision.Equals("Correct"))
        {
            Line2_1.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 1 && Text == 0 && Decision.Equals("InCorrect"))
        {
            Line2_1.SetActive(true);
            Line2_1.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line2_1));
        }

        // Button 2 - 2
        if (Animal == 1 && Text == 1 && Decision.Equals("Correct"))
        {
            Line2_2.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 1 && Text == 1 && Decision.Equals("InCorrect"))
        {
            Line2_2.SetActive(true);
            Line2_2.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line2_2));
        }

        // Button 2 - 3
        if (Animal == 1 && Text == 2 && Decision.Equals("Correct"))
        {
            Line2_3.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 1 && Text == 2 && Decision.Equals("InCorrect"))
        {
            Line2_3.SetActive(true);
            Line2_3.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line2_3));
        }

        // Button 2 - 4
        if (Animal == 1 && Text == 3 && Decision.Equals("Correct"))
        {
            Line2_4.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 1 && Text == 3 && Decision.Equals("InCorrect"))
        {
            Line2_4.SetActive(true);
            Line2_4.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line2_4));
        }

        // Button 2 - 5
        if (Animal == 1 && Text == 4 && Decision.Equals("Correct"))
        {
            Line2_5.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 1 && Text == 4 && Decision.Equals("InCorrect"))
        {
            Line2_5.SetActive(true);
            Line2_5.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line2_5));
        }
        /////////////////////////////////////////////////////////////////////
        ///
        // Button 3 - 1
        if (Animal == 2 && Text == 0 && Decision.Equals("Correct"))
        {
            Line3_1.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 2 && Text == 0 && Decision.Equals("InCorrect"))
        {
            Line3_1.SetActive(true);
            Line3_1.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line3_1));
        }

        // Button 3 - 2
        if (Animal == 2 && Text == 1 && Decision.Equals("Correct"))
        {
            Line3_2.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 2 && Text == 1 && Decision.Equals("InCorrect"))
        {
            Line3_2.SetActive(true);
            Line3_2.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line3_2));
        }

        // Button 3 - 3
        if (Animal == 2 && Text == 2 && Decision.Equals("Correct"))
        {
            Line3_3.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 2 && Text == 2 && Decision.Equals("InCorrect"))
        {
            Line3_3.SetActive(true);
            Line3_3.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line3_3));
        }

        // Button 3 - 4
        if (Animal == 2 && Text == 3 && Decision.Equals("Correct"))
        {
            Line3_4.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 2 && Text == 3 && Decision.Equals("InCorrect"))
        {
            Line3_4.SetActive(true);
            Line3_4.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line3_4));
        }

        // Button 3 - 5
        if (Animal == 2 && Text == 4 && Decision.Equals("Correct"))
        {
            Line3_5.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 2 && Text == 4 && Decision.Equals("InCorrect"))
        {
            Line3_5.SetActive(true);
            Line3_5.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line3_5));
        }
        /////////////////////////////////////////////////////////////////////
        ///

        // Button 4 - 1
        if (Animal == 3 && Text == 0 && Decision.Equals("Correct"))
        {
            Line4_1.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 3 && Text == 0 && Decision.Equals("InCorrect"))
        {
            Line4_1.SetActive(true);
            Line4_1.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line4_1));
        }

        // Button 4 - 2
        if (Animal == 3 && Text == 1 && Decision.Equals("Correct"))
        {
            Line4_2.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 3 && Text == 1 && Decision.Equals("InCorrect"))
        {
            Line4_2.SetActive(true);
            Line4_2.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line4_2));
        }

        // Button 4 - 3
        if (Animal == 3 && Text == 2 && Decision.Equals("Correct"))
        {
            Line4_3.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 3 && Text == 2 && Decision.Equals("InCorrect"))
        {
            Line4_3.SetActive(true);
            Line4_3.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line4_3));
        }

        // Button 4 - 4
        if (Animal == 3 && Text == 3 && Decision.Equals("Correct"))
        {
            Line4_4.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 3 && Text == 3 && Decision.Equals("InCorrect"))
        {
            Line4_4.SetActive(true);
            Line4_4.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line4_4));
        }

        // Button 4 - 5
        if (Animal == 3 && Text == 4 && Decision.Equals("Correct"))
        {
            Line4_5.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 3 && Text == 4 && Decision.Equals("InCorrect"))
        {
            Line4_5.SetActive(true);
            Line4_5.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line4_5));
        }
        /////////////////////////////////////////////////////////////////////
        ///
        // Button 5 - 1
        if (Animal == 4 && Text == 0 && Decision.Equals("Correct"))
        {
            Line5_1.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 4 && Text == 0 && Decision.Equals("InCorrect"))
        {
            Line5_1.SetActive(true);
            Line5_1.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line5_1));
        }

        // Button 5 - 2
        if (Animal == 4 && Text == 1 && Decision.Equals("Correct"))
        {
            Line5_2.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 4 && Text == 1 && Decision.Equals("InCorrect"))
        {
            Line5_2.SetActive(true);
            Line5_2.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line5_2));
        }

        // Button 5 - 3
        if (Animal == 4 && Text == 2 && Decision.Equals("Correct"))
        {
            Line5_3.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 4 && Text == 2 && Decision.Equals("InCorrect"))
        {
            Line5_3.SetActive(true);
            Line5_3.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line5_3));
        }

        // Button 5 - 4
        if (Animal == 4 && Text == 3 && Decision.Equals("Correct"))
        {
            Line5_4.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 4 && Text == 3 && Decision.Equals("InCorrect"))
        {
            Line5_4.SetActive(true);
            Line5_4.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line5_4));
        }

        // Button 5 - 5
        if (Animal == 4 && Text == 4 && Decision.Equals("Correct"))
        {
            Line5_5.SetActive(true);
            ButtonList[Animal].enabled = false;
            ButtonList2[Text].enabled = false;
        }
        else if (Animal == 4 && Text == 4 && Decision.Equals("InCorrect"))
        {
            Line5_5.SetActive(true);
            Line5_5.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(CallDisappear(Line5_5));
        }
    }

    //public void DisableButtons()
    //{
    //    Debug.Log(ButtonList.Count);
    //    for(int i = 0; i < ButtonList.Count; i ++)
    //    {
    //        ButtonList[i].enabled = false;
    //    }
    //}

    //public void DisableText()
    //{   Debug.Log(ButtonList2.Count);
    //    for (int i = 0; i < ButtonList2.Count; i++)
    //    {
    //        ButtonList2[i].enabled = false;
    //    }
    //}

    public void EnableButtons()
    {
        Debug.Log(ButtonList.Count);
        for (int i = 0; i < ButtonList.Count; i++)
        {
            ButtonList[i].enabled = true;
        }
    }

    public void EnableText()
    {
        Debug.Log(ButtonList2.Count);
        for (int i = 0; i < ButtonList2.Count; i++)
        {
            ButtonList2[i].enabled = true;
        }
    }

    public void DisableLine()
    {
        Debug.Log(LineList.Count);
        for (int i = 0; i < LineList.Count; i++)
        {
            LineList[i].SetActive(false);
        }
    }

    private void Restart()
    {
        ACounter = 0;
        correctText = 0;
        CorrectSprite = 0;
        CorrectCounter = 0;
        Decision = null;
        TempList.Clear();
        TempList2.Clear();

        EnableButtons();
        EnableText();
        DisableLine();

        while (ACounter < 5)
        {
            TempIndex = Random.Range(0, 17);
            if (!TempList.Contains(TempIndex))
            {
                CurrentImage = ButtonList[ACounter].GetComponent<Image>();
                CurrentImage.sprite = ImageList[TempIndex];
                TempList.Add(TempIndex);
                TempList2.Add(TempIndex);
                ACounter++;
            }
        }
        string TempName;
        TempList.Sort();
        ACounter = 0;
        //Debug.Log(AnimalList[TempList[ACounter]]);
        while (ACounter < 5)
        {
            CurrentText = TextList[ACounter].GetComponent<Text>();
            TempName = AnimalList[TempList[ACounter]];
            CurrentText.text = TempName;
            ACounter++;

        }

     //   match = 0;
    }

    private IEnumerator CallDisappear(GameObject gameObject)
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }
}

    

