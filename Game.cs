using System;

public class Game
{
    private Difficulty difficulty;
    private int[] solution;
    private int[][] answers;
    private int[][] answerAccuracy;
    private int currentTurn;

    //Maybe make this more object oriented
	public Game(Difficulty difficulty)
	{
        this.difficulty = difficulty;
        currentTurn = 0;
        solution = new int[difficulty.numberOfBits];
        answers = new int[difficulty.numberOfTurns];
        answerAccuracy = new int[difficulty.numberOfTurns];
        
	}

    public bool checkAnswer(int[] playerAnswer)
	{
        try
        {
            if (answers[currentTurn] == null)
                answers[currentTurn] = new int[difficulty.numberOfBits];

            for (int codeBit = 0; codeBit < difficulty.numberOfBits; codeBit++)
            {
                answers[currentTurn][codeBit] = playerAnswer[codeBit];
            }
            int bitsCorrect = 0;
            int bitsWrongPlace = 0;
            int[] tempSolution = new int[bits];
            int i = 0;
            foreach (int codeBit in solution)
                tempSolution[i++] = codeBit;

            //check the number of bits that are correct and in the right place
            for (i = 0; i < difficulty.numberOfBits; i++)
            {
                if (playerAnswer[i] == tempSolution[i])
                {
                    bitsCorrect++;
                    tempSolution[j] = difficulty.baseNumber + 2; //this needlessly guarantees a number that should not naturally exist in the solution
                }
            }

            if (answerAccuracy[currentTurn] == null)
                answerAccuracy[currentTurn] = new int[2];
            answerAccuracy[currentTurn][0] = bitsCorrect;

            if (bitsCorrect == difficulty.numberOfBits)
                return true;

            //check for the number of bits that are correct but in the wrong place
            for (i = 0; i < difficulty.numberOfBits; i++)
            {
                for (int j = 0; j < difficulty.numberOfBits; j++)
                {
                    if (playerAnswer[i] == tempSolution[j])
                    {
                        bitsWrongPlace++;
                        tempSolution[j] = difficulty.baseNumber + 2; //this needlessly guarantees a number that should not naturally exist in the solution
                        break;
                    }
                }
            }
            answerAccuracy[currentTurn][1] = bitsWrongPlace;
            return false;
        }
        finally
        {
            currentTurn++;
        }
	}

    //Done
    public void generatePermutation(int baseNumber) {
        Random random = new Random();
        for (int i = 0; i < difficulty.numberOfBits; i++)
        {
            solution[i] = random.Next(0, baseNumber);
        }
    }

    //To be fully implemented later, lolz
    public int computeScore() {
        if (turnsRemaining > 0)
        {
            return 100;
        }
        else {
            return 0;
        }
    }
}