using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutor : MonoBehaviour {


    [SerializeField] GameObject presentation;
    [SerializeField] Animator presentationAnimator;
    [SerializeField] int presentationPhase = 0;
    [SerializeField] Text descriptionText;
    [SerializeField] GameObject movementTutorial;

	// Use this for initialization
	void Start () {
        presentationAnimator = presentation.GetComponent<Animator>();
        presentationPhase = 0;
        movementTutorial.SetActive(false);
    }
	
    public void ClickNext()
    {
        presentationPhase++;
        presentationAnimator.SetInteger("Presentation", presentationPhase);
    }

    public void LoadNextScene(int sceneNumber)
    {
        Application.LoadLevel(sceneNumber);
    }

	void Update () {

        switch (presentationPhase)
        {
            case 0:
                descriptionText.text = "Collect Taco";
                break;
            case 1:
                descriptionText.text = "Avoid Tequila";
                break;
            case 2:
                descriptionText.text = "Sombrero gives you Power";
                break;
            default:
                descriptionText.text = "Tap the screen to move";
                movementTutorial.SetActive(true);
                break;

        }
		
	}


}
