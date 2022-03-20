﻿using KKAPI.MainGame;
using UnityEngine;

namespace SexFaces
{
    internal class GameController : GameCustomFunctionController
    {
        protected override void OnStartH(MonoBehaviour proc, HFlag hFlag, bool vr)
        {
            SexFacesPlugin.Logger.LogDebug("H scene started.");
            hFlag.lstHeroine.ForEach(heroine => GetController(heroine).RunLoop(
                hFlag, heroine.HExperience));
            hFlag.player.chaCtrl.GetComponent<SexFacesController>().RunLoop(
                hFlag, hFlag.lstHeroine[0].HExperience);
        }

        private static SexFacesController GetController(SaveData.Heroine heroine)
        {
            return heroine.chaCtrl.GetComponent<SexFacesController>();
        }
    }
}