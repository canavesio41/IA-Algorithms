﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Events
{
    StartMoving,
    FinishedMining,
    FinishedDeploying
}

public enum States
{
    Idle,
    MovingToGoldmine,
    Mining,
    MovingToCastle,
    Deploying
}

public class FSM : MonoBehaviour {
    public int[,] _stateMachineGrid;

    int _currentState = 0;

    public void init(int statesCount, int eventsCount) {
        _stateMachineGrid = new int[statesCount, eventsCount];

        for (int x = 0; x < statesCount; x++) {
            for (int y = 0; y < eventsCount; y++)
                _stateMachineGrid[x, y] = -1;
        }
    }

    public void setRelation(int originState, int relatedEvent, int targetState) {
    }

    public void setEvent(int eventToCheck) {

    }

    public int getEvent() {
        return _currentState;
    }
}
