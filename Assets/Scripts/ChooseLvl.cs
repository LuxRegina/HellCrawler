using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseLvl : MonoBehaviour
{
    public int levelIndex; // H�ller reda p� vilken niv� knappen representerar

    void Start()
    {
        // H�mta referensen till knappen och l�gg till en lyssnare f�r dess klickh�ndelse
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        // Ladda den specifika niv�n n�r knappen klickas
        SceneManager.LoadScene(levelIndex);
    }
}
