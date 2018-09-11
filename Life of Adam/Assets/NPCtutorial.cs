using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtutorial : MonoBehaviour 
{
    [Header("Add Lightoobject door entrance")]
    [SerializeField]
    private GameObject[] HappyEntrance;
    public GameObject NpcText;
    public GameObject NpcInterActionText;
    public NpcAnimationCs npc;
    private LevelManagerCs lv;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //.FindObjectOfType<PauseCs>().OnPause();

    void OnTriggerEnter(Collider other)
    {
        NpcInterActionText.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Object.FindObjectOfType<PauseCs>().OnPause();
            NpcInterActionText.SetActive(false);
            for (int i = 0; i < HappyEntrance.Length; i++)
            {

                HappyEntrance[i].SetActive(false);
            }
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        NpcInterActionText.SetActive(false);
    }
}
