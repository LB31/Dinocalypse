using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> dialogs;

    public int time = 5;

    void Start()
    {
        foreach (GameObject item in dialogs)
        {
            item.SetActive(false);
        }

        NextDialog();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private async void NextDialog()
    {
        

        foreach (GameObject item in dialogs)
        {
            item.SetActive(true);
            await Task.Delay(time * 1000);
            item.SetActive(false);
        }
    }
}
