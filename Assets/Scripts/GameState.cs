﻿using UnityEngine;
using System.Collections.Generic;

public class GameState : MonoBehaviour {

    
    static public float remainingTime;
    static public int totalScore;
    static public List<PlayerInfo> players;

    static public void init(List<PlayerInfo> players0, float remainingTime0)
    {
        remainingTime = remainingTime0;
        players = players0;
    }

    static public void increaseScore(string playerColor)
    {
        for (int i = 0; i < players.Count; i++)
        {
            if (players[i].playerColor.Equals(playerColor))
            {
                // TODO : this is dirty, take time to get references to these elements
                PlayerInfo playerInfo = players[i];
                playerInfo.hit++;
                players[i] = playerInfo;
            }
        }
        totalScore++;
    }

    static public void reset()
    {
        remainingTime = 0;
        totalScore = 0;
        for (int i = 0; i < players.Count; i++)
        {
            PlayerInfo currentPlayer;
            currentPlayer.hit = 0;
            currentPlayer.name = "";
            currentPlayer.playerColor = "";

            players[i] = currentPlayer;
        }
    }
}
public struct PlayerInfo
{
    public int hit;
    public string name;
    public string playerColor;
}
