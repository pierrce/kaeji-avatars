﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;

namespace Valve.VR
{
    public class SteamVR_Settings : ScriptableObject
    {
        private static SteamVR_Settings _instance;
        public static SteamVR_Settings instance
        {
            get
            {
                LoadInstance();

                return _instance;
            }
        }

        private static void LoadInstance()
        {
            if (_instance == null)
            {
                _instance = Resources.Load<SteamVR_Settings>("SteamVR_Settings");

                if (_instance == null)
                {
                    _instance = SteamVR_Settings.CreateInstance<SteamVR_Settings>();

#if UNITY_EDITOR
                    string folderPath = SteamVR.GetResourcesFolderPath(true);
                    string assetPath = System.IO.Path.Combine(folderPath, "SteamVR_Settings.asset");

                    UnityEditor.AssetDatabase.CreateAsset(_instance, assetPath);
                    UnityEditor.AssetDatabase.SaveAssets();
#endif
                }

                if (string.IsNullOrEmpty(_instance.appKey))
                {
                    _instance.appKey = SteamVR.GenerateAppKey();
                    Debug.Log("[SteamVR] Generated you a temporary app key of: " + _instance.appKey + ". Please change this to your real app key before publishing to steam. This can be changed in Assets/SteamVR/Resources/SteamVR_Settings");
#if UNITY_EDITOR
                    UnityEditor.EditorUtility.SetDirty(_instance);
                    UnityEditor.AssetDatabase.SaveAssets();
#endif
                }
            }
        }

        public bool pauseGameWhenDashboardVisible = true;
        public bool lockPhysicsUpdateRateToRenderFrequency = true;
        public Valve.VR.ETrackingUniverseOrigin trackingSpace = Valve.VR.ETrackingUniverseOrigin.TrackingUniverseStanding;

        [Tooltip("Filename local to the project root (or executable, in a build)")]
        public string actionsFilePath = "actions.json";

        [Tooltip("Path local to the Assets folder")]
        public string steamVRInputPath = "SteamVR_Input";

        public SteamVR_UpdateModes inputUpdateMode = SteamVR_UpdateModes.OnUpdate;
        public SteamVR_UpdateModes poseUpdateMode = SteamVR_UpdateModes.OnPreCull;

        public bool activateFirstActionSetOnStart = true;

        [Tooltip("App keys are generally \"steam.app.appid\". If you don't have a steamworks app id yet you can use a generated id.")]
        public string appKey;

        public bool IsInputUpdateMode(SteamVR_UpdateModes tocheck)
        {
            return (inputUpdateMode & tocheck) == tocheck;
        }
        public bool IsPoseUpdateMode(SteamVR_UpdateModes tocheck)
        {
            return (poseUpdateMode & tocheck) == tocheck;
        }

        public static void VerifyScriptableObject()
        {
            LoadInstance();
        }
    }
}