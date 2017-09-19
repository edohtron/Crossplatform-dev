using UnityEngine;
using UnityEngine.UI;
using CnControls;
using UnityEngine.SceneManagement;

public class ChoosePlanetScript : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    public Image choiceImage;
    public Image[] cnButtons;
    public Sprite sprite;
    public Sprite tp;
    public int choiceNo;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
        cnButtons[0].sprite = tp;
        cnButtons[1].sprite = sprite;
        cnButtons[2].sprite = tp;
        choiceNo = 2;

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(choiceImage.rectTransform.position);
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
           if(hit.collider.name == "Earth")
            {
                choiceImage.rectTransform.position = new Vector3(559.6f - 204.0f - 203.0f, 292, 0);
            }
           else if (hit.collider.name == "Random")
            {
                choiceImage.rectTransform.position = new Vector3(559.6f - 204.0f, 292, 0);
            }
           else if (hit.collider.name == "Sun")
            {
                choiceImage.rectTransform.position = new Vector3(559.6f, 292, 0);
            }
        }

        if(CnInputManager.GetButtonDown("Earth"))
        {
            cnButtons[0].sprite = sprite;
            cnButtons[1].sprite = tp;
            cnButtons[2].sprite = tp;
            choiceNo = 1;
        }
        if (CnInputManager.GetButtonDown("Random"))
        {
            cnButtons[0].sprite = tp;
            cnButtons[1].sprite = sprite;
            cnButtons[2].sprite = tp;
            choiceNo = 2;
        }
        if (CnInputManager.GetButtonDown("Sun"))
        {
            cnButtons[0].sprite = tp;
            cnButtons[1].sprite = tp;
            cnButtons[2].sprite = sprite;
            choiceNo = 3;
        }
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
