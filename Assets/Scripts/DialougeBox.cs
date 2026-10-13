using UnityEngine;
using System;

public class DialougeBox : MonoBehaviour
{
    public TheDialougeBox ThisDialougeBox;
    private GameObject DialougeBoxObject;

    void Awake()
    {
        DialougeBoxObject = GameObject.Find("DialougeBox");
        DialougeBoxObject.SetActive(false);
    }

    public void ShowDialouge()
    {
        DialougeBoxObject.SetActive(true);
        DialougeBoxObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = ThisDialougeBox.Dialouge[0];

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}


[Serializable]
public class TheDialougeBox
{
    [SerializeField]
    public string[] Dialouge;





}
