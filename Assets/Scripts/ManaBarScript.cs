﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBarScript : MonoBehaviour
{
	public Slider slider;

	public void setMana(int mana)
	{
		slider.value = mana;
	}

	public void setMaxMana(int maxMana)
	{
		slider.maxValue = maxMana;
		slider.value = maxMana;
	}
}
