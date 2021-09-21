using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
	public string nextLevel0 = "Level0";
	public string nextLevel1 = "Level1";
    public string nextLevel2 = "Level2";
    public string nextLevel3 = "Level3";
    public string nextLevel4 = "Level4";

	public int levelToUnlock0 = 0;
	public int levelToUnlock1 = 1;
    public int levelToUnlock2 = 2;
    public int levelToUnlock3 = 3;
    public int levelToUnlock4 = 4;

	public SceneFader sceneFader;

	public void Continue0()
	{

		sceneFader.FadeTo(nextLevel0);

		if (PlayerPrefs.GetInt("levelReached") < levelToUnlock0)
		{
			PlayerPrefs.SetInt("levelReached", levelToUnlock0);

		}
	}

	public void Continue1()
	{

		sceneFader.FadeTo(nextLevel1);

		if (PlayerPrefs.GetInt("levelReached") < levelToUnlock1)
		{
			PlayerPrefs.SetInt("levelReached", levelToUnlock1);

		}
	}

	public void Continue2()
	{

		sceneFader.FadeTo(nextLevel2);

		if (PlayerPrefs.GetInt("levelReached") < levelToUnlock2)
		{
			PlayerPrefs.SetInt("levelReached", levelToUnlock2);
		}
	}

	public void Continue3()
	{
		if (PlayerPrefs.GetInt("levelReached") < levelToUnlock3)
		{
			PlayerPrefs.SetInt("levelReached", levelToUnlock3);
		}
		sceneFader.FadeTo(nextLevel3);
	}

	public void Continue4()
	{
		if (PlayerPrefs.GetInt("levelReached") < levelToUnlock4)
		{
			PlayerPrefs.SetInt("levelReached", levelToUnlock4);
		}
		sceneFader.FadeTo(nextLevel4);
	}
}
