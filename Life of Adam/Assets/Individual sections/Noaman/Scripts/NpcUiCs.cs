using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcUiCs : MonoBehaviour 
{
    [SerializeField]
    private GameObject thingToEnable;
    [Header("Add All pickable objects here")]
    [SerializeField]
    private GameObject[] PickUps;
    public GameObject NpcText;
    public NpcAnimationCs npc;
    private LevelManagerCs lv;
    
	// Use this for initialization
	void Start () 
	{
        lv= Object.FindObjectOfType<LevelManagerCs>();
        NpcText.SetActive(false);
        thingToEnable.SetActive(false);
        for (int i = 0; i < PickUps.Length; i++)
        {
            PickUps[i].SetActive(false);
        }
    }
	void OnTriggerEnter(Collider other)
	{

        GameObject.Find("PauseHandler").SetActive(false);
        Object.FindObjectOfType<PauseCs>().OnPause();
        thingToEnable.SetActive(true);
        NpcText.SetActive(true);
        // npc.SetInteractive();

        for (int i = 0; i < PickUps.Length; i++)
        {
            PickUps[i].SetActive(true);
        }
        this.gameObject.SetActive(false);

    }

}
