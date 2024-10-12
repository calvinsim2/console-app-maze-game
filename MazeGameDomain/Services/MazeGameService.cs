﻿using MazeGameDomain.Constants;
using MazeGameDomain.Enums;
using MazeGameDomain.Interfaces;
using MazeGameDomain.Interfaces.DecisionTrees;
using MazeGameDomain.Models;
using MazeGameDomain.Services.DecisionTrees;

namespace MazeGameDomain.Services
{
    public class MazeGameService : IMazeGameService
    {
        private readonly IIceCavern _iceCavern;
        public MazeGameService(IIceCavern iceCavern) 
        {
            _iceCavern = iceCavern;
        }

        public void StartGame(MazeGameDataModel mazeGameDataModel)
        {
            MazeGameAsync(mazeGameDataModel);
        }
        public MazeGameFlow MazeGameAsync(MazeGameDataModel mazeGameDataModel, 
                                                      MazeGameFlow startingStep = MazeGameFlow.Town)
        {
            MazeGameFlow currentStep = startingStep;
            MazeGameFlow breaktree = startingStep;

            while (breaktree == startingStep)
            {
                switch (currentStep)
                {
                    case MazeGameFlow.Town:
                        currentStep = MazeGameFlow.IceCavern;
                        break;

                    case MazeGameFlow.IceCavern:
                        MazeGameDecisionQuery iceCavernCreate = _iceCavern.TransverseIceCavernAsync(mazeGameDataModel);
                        currentStep = iceCavernCreate.EvaluateAsync();
                        break;

                    case MazeGameFlow.FireCavern:
                        break;

                    case MazeGameFlow.Death:
                        Console.WriteLine(InGameMessage.Death);
                        break;

                    default: break;
                }
            }

            return currentStep;
        }
    }
}
