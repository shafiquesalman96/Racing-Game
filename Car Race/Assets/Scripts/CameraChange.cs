using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

	public GameObject NormalView;
	public GameObject FarView;
	public GameObject CloseView;
	public int CamMode;

	void Update()
	{
		if (Input.GetButtonDown("Viewmode"))
		{
			if (CamMode == 2)
			{
				CamMode = 0;
			}
			else
			{
				CamMode += 1;
			}
			StartCoroutine(ModeChange());
		}
	}

	IEnumerator ModeChange()
	{
		yield return new WaitForSeconds(0.01f);
		if (CamMode == 0)
		{
			NormalView.SetActive(true);
			CloseView.SetActive(false);
		}
		if (CamMode == 1)
		{
			FarView.SetActive(true);
			NormalView.SetActive(false);
		}
		if (CamMode == 2)
		{
			CloseView.SetActive(true);
			FarView.SetActive(false);
		}

	}
}