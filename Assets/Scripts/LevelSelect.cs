using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void SelectLevel1()
    {
            SceneManager.LoadScene(2);
  
    }
    public void SelectLevel2()
    {
        SceneManager.LoadScene(3);

    }
    public void SelectLevel3()
    {
        SceneManager.LoadScene(4);

    }


}
