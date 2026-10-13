using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject OptionsMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Playbutton()
    {
        SceneManager.LoadScene("Finality");
    }

    public void Optionsbutton()
    {
        OptionsMenu.SetActive(OptionsMenu.activeSelf != OptionsMenu.activeSelf);
    }

    public void Quitbutton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
