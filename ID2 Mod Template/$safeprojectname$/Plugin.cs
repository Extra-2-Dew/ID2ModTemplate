﻿using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections;
using UnityEngine;

namespace ID2.$safeprojectname$;

[BepInPlugin("id2.$safeprojectname$", "$projectname$", "0.1.0")]
public class Plugin : BaseUnityPlugin
{
	internal static new ManualLogSource Logger;
	private static Plugin instance;

	public static Plugin Instance => instance;

	private void Awake()
	{
		instance = this;
		Logger = base.Logger;

		Logger.LogInfo($"Plugin $projectname$ (id2.$safeprojectname$) is loaded!");

		try
		{
			// Mod initialization code here

			var harmony = new Harmony("id2.$safeprojectname$");
			harmony.PatchAll();
		}
		catch (System.Exception err)
		{
			Logger.LogError(err);
		}
	}

	/// <summary>
	/// Starts a Coroutine on the Plugin MonoBehaviour.<br/>
	/// This is useful for if you need to start a Coroutine<br/>from a non-MonoBehaviour class.
	/// </summary>
	/// <param name="routine">The routine to start.</param>
	/// <returns>The started Coroutine.</returns>
	public static Coroutine StartRoutine(IEnumerator routine)
	{
		return Instance.StartCoroutine(routine);
	}
}