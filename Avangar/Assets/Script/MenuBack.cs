using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuBack : MonoBehaviour {

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }


}
