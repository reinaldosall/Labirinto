using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button1 : MonoBehaviour
{
    public Button yourButton;
   	public string LevelName;

	void Start ()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		
	 	 SceneManager.LoadScene(LevelName);

		Debug.Log ("You have clicked the button!");
	}
}
