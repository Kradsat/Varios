using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    [SerializeField] private Dice dice;
    [SerializeField] private List<Step> playerStep = new List<Step>();
    [SerializeField] private int turn;
    [SerializeField] private int playerNumber;
    [SerializeField] public bool SetDiceRoll = false;

    private void Start()
    {
        Init();
        foreach (var VARIABLE in playerStep)
        {
            Debug.Log(VARIABLE.gameObject.name);
        }
       
    }

    public void Init()
    {
        turn = 0; // number of turns
        playerNumber = playerStep.Count; // number of players
        SetDiceRoll = false;
    }

    private void turnCheck()
    {
        if (playerStep.Count == turn)
        {
            turn = 0;
        }
    }

    public void SetTurn()
    {
        if (!SetDiceRoll)
        {
            Debug.Log("======SetTurn======");
            if (turn + 1 == playerStep.Count)
            {
                turn = 0;
            }
            else
            { 
                turn += 1;
            }

        }
        SetDiceRoll = true;
    }

    public void SetTurn(int TurnNO)
    {
        turn += TurnNO;
    }

    public void DiceRoll()
    {
        if (SetDiceRoll)
        {
            playerStep[turn].SetStep(dice.GetDiceNumber());
            turnCheck();
            SetDiceRoll = false;
        }
    }
}
