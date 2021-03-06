﻿using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	public static T instance;

	protected virtual void Awake()
	{
		instance = this as T;
	}

	protected virtual void OnDestroy()
	{
		if (instance == this) instance = null;
	}
}