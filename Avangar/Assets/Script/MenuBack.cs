using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuBack : MonoBehaviour {
//volta para o menu
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }


}
