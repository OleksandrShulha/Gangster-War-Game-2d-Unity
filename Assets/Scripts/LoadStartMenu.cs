using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartMenu : MonoBehaviour
{
    [SerializeField] float timeForLoadStartMenu = 2f;
    int currentIndexScene;

    void Start()
    {
        //получаем индекс текущей сцены
        currentIndexScene = SceneManager.GetActiveScene().buildIndex;

        //примеяем задержку только для нулевой сцены
        if (currentIndexScene == 0)
        {
            StartCoroutine(WaitAndLoadStartMenu());
        }
        else
        {
            LoadNextScene();
        } 
    }





    //грузим с задержкой сцену
    IEnumerator WaitAndLoadStartMenu()
    {
        yield return new WaitForSeconds(timeForLoadStartMenu);
        LoadNextScene();
    }

    
    //метод загрузки следующей сцены
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentIndexScene + 1);
    }


}
